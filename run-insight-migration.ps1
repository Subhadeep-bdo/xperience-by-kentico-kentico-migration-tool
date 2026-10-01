<#
.SYNOPSIS
    One-command reproduction of the "Insight" migration flow plus the custom-module -> page-types
    migration for BDO Metadata and BDO Deal Cards.

.DESCRIPTION
    Runs, in dependency order (Insight is intentionally LAST because it references the other pages):
      1. BDO Metadata custom module  -> XbyK page tree   (seed-bdo-metadata-pages.sql)
      2. BDO Deal Cards custom module -> XbyK page tree  (seed-bdo-dealcards-pages.sql)
      3. Build the CLI, then migrate all pages that Insights REFERENCE ("Section Services onwards"):
         Services / Industries / Specialties / Locations page types.
      4. (LAST) Insight page migration (BDO.SectionInsightsPage + BDO.Insight), then create the
         CopyInsight content-hub items from K13 CTA + Content sharing and reference them from
         Insight.InsightContent (seed-copyinsight-contenthub.sql).

    Each `migrate --pages` run temporarily scopes appsettings IncludeCodeNames and restores it after.
    All SQL seeds are idempotent (delete + rebuild their subtree), so the whole script is re-runnable.

.EXAMPLE
    ./run-insight-migration.ps1
    ./run-insight-migration.ps1 -SkipModules       # only referenced pages + Insight + CopyInsight
    ./run-insight-migration.ps1 -SkipBuild         # reuse existing build
#>
[CmdletBinding()]
param(
    [string]$Server              = '(localdb)\MSSQLLocalDB',
    [string]$SourceDb            = 'BDO-DB-GWT-TST-EUR',
    [string]$TargetDb            = 'bdo-db-gwt-xbyk-dev-local-25082026',
    [string]$DbUser              = 'sa',
    [string]$DbPassword          = 'Admin!123',
    [switch]$SkipModules,        # skip metadata + deal cards module->pages seeds
    [switch]$SkipBuild,          # skip building the CLI
    [switch]$SkipReferencedPages,# skip migrating the Insight-referenced page types
    [switch]$SkipInsight         # skip the final Insight page migration + CopyInsight seed
)

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $root

# Page types that Insights reference (migrated BEFORE Insights) - "Section Services onwards".
$referencedClasses = @(
    'BDO.SectionServices', 'BDO.BusinessLine', 'BDO.ServiceArea', 'BDO.Service',
    'BDO.SectionIndustries', 'BDO.IndustryCategory', 'BDO.Industry', 'BDO.IndustryService',
    'BDO.SectionSpecialties', 'BDO.SpecialtiesCategory', 'BDO.SpecialtiesArea', 'BDO.SpecialtiesPage',
    'BDO.Locations', 'BDO.LocationCity', 'BDO.LocationOffice'
)
$insightClasses = @('BDO.SectionInsightsPage', 'BDO.Insight')

function Write-Step($n, $msg) { Write-Host "`n==== STEP $n : $msg ====" -ForegroundColor Cyan }

function Invoke-Sql([string]$db, [string]$file) {
    if (-not (Test-Path $file)) { throw "SQL file not found: $file" }
    Write-Host "  sqlcmd -> $db : $file" -ForegroundColor DarkGray
    sqlcmd -S $Server -d $db -U $DbUser -P $DbPassword -N -C -W -b -i $file
    if ($LASTEXITCODE -ne 0) { throw "sqlcmd failed ($file) with exit code $LASTEXITCODE" }
}

# Runs `migrate --pages` scoped to the given classes, restoring appsettings afterwards.
function Invoke-ScopedPageMigration([string[]]$classes) {
    $appsettings = Join-Path $root 'Migration.Tool.CLI/appsettings.json'
    $backup      = "$appsettings.bak"
    Copy-Item $appsettings $backup -Force
    try {
        $list   = ($classes | ForEach-Object { '"' + $_ + '"' }) -join ', '
        $scoped = '"IncludeCodeNames": [ ' + $list + ' ]'
        $raw    = Get-Content $appsettings -Raw
        $raw    = [regex]::Replace($raw, '"IncludeCodeNames"\s*:\s*\[[^\]]*\]', $scoped)
        Set-Content -Path $appsettings -Value $raw -Encoding UTF8

        Push-Location (Join-Path $root 'Migration.Tool.CLI')
        try {
            dotnet run --project Migration.Tool.CLI.csproj --configuration Release --no-build -- migrate --pages --bypass-dependency-check
            if ($LASTEXITCODE -ne 0) { throw "migrate --pages failed with exit code $LASTEXITCODE" }
        } finally { Pop-Location }
    } finally {
        Copy-Item $backup $appsettings -Force
        Remove-Item $backup -Force -ErrorAction SilentlyContinue
        Write-Host '  appsettings.json restored.' -ForegroundColor DarkGray
    }
}

# ---- 1 & 2. Custom module -> pages (referenced by Insights) ----
if (-not $SkipModules) {
    Write-Step 1 'BDO Metadata custom module -> XbyK page tree'
    Invoke-Sql $TargetDb (Join-Path $root 'seed-bdo-metadata-pages.sql')

    Write-Step 2 'BDO Deal Cards custom module -> XbyK page tree'
    Invoke-Sql $TargetDb (Join-Path $root 'seed-bdo-dealcards-pages.sql')
} else {
    Write-Host 'Skipping module->pages seeds (-SkipModules).' -ForegroundColor Yellow
}

# ---- 3. Build + migrate the Insight-referenced page types (Section Services onwards) ----
if (-not $SkipBuild) {
    Write-Step 3 'Build Migration Tool CLI'
    dotnet build Migration.Tool.CLI/Migration.Tool.CLI.csproj --configuration Release --no-restore
    if ($LASTEXITCODE -ne 0) { throw "Build failed with exit code $LASTEXITCODE" }
} else {
    Write-Host 'Skipping build (-SkipBuild).' -ForegroundColor Yellow
}

if (-not $SkipReferencedPages) {
    Write-Step 3 'Migrate Insight-referenced pages (Section Services / Industries / Specialties / Locations)'
    Invoke-ScopedPageMigration $referencedClasses
} else {
    Write-Host 'Skipping referenced-pages migration (-SkipReferencedPages).' -ForegroundColor Yellow
}

# ---- 4. (LAST) Insight page migration + CopyInsight content hub ----
if (-not $SkipInsight) {
    Write-Step 4 'Insight page migration (BDO.SectionInsightsPage + BDO.Insight)'
    Invoke-ScopedPageMigration $insightClasses

    Write-Step 4 'CopyInsight content-hub items + Insight.InsightContent references'
    Invoke-Sql $TargetDb (Join-Path $root 'seed-copyinsight-contenthub.sql')

    Write-Step 4 'Wire Insight metadata/page reference fields to migrated pages'
    Invoke-Sql $TargetDb (Join-Path $root 'seed-insight-references.sql')
} else {
    Write-Host 'Skipping Insight migration (-SkipInsight).' -ForegroundColor Yellow
}

Write-Host "`nAll requested steps completed." -ForegroundColor Green
