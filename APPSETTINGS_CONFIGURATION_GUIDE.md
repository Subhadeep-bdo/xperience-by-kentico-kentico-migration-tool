# Migration Tool Configuration Summary

**Generated:** 2026-08-20  
**Scope:** 8-Site Multi-Workspace Migration  
**Plan Source:** `./migration-detail.md` + Infrastructure Discovery

---

## Overview

This document explains your Migration Tool configuration and provides per-site appsettings.json templates. Each site requires its own workspace and configuration file.

---

## Configuration Settings

### Infrastructure Settings (Always Required)

| Setting | Value | Purpose | Source |
| --- | --- | --- | --- |
| **KxConnectionString** | `Server=(localdb)\\MSSQLLocalDB;Database=BDO-DB-GWT-TST-EUR;Integrated Security=true;Encrypt=False;` | KX13 database access | Discovered from current appsettings.json |
| **KxCmsDirPath** | `C:\\Work\\GWT\\GWT.Web\\CMS` | KX13 CMS root directory (media, files, bin) | Discovered from current appsettings.json |
| **XbyKDirPath** | `C:\\Work\\GWT\\GWT.XbyK.Web\\BDO.GWT.GLOBAL` | XbyK project root directory | Discovered from current appsettings.json |
| **TargetWorkspaceName** | `BDO-Demo` (varies per site) | XbyK workspace name | Per-site configuration |
| **MigrationProtocolPath** | `C:\\Work\\GWT\\...\\MigrationProtocol\\protocol.txt` | Protocol log for evaluation | **REQUIRED** for migrate-content-eval skill |

### Content Model Conversion Settings

| Setting | Value | Purpose | From Migration Plan |
| --- | --- | --- | --- |
| **ConvertClassesToContentHub** | `BDO.Insight` | Classes becoming reusable content items (not webpages) | Migration Detail: "BDO.Insight → Content Hub conversion" |
| **CreateReusableFieldSchemaForClasses** | `MetadataFields;HeroFields;LocationFields` | Semicolon-separated reusable field schemas | Migration Detail: "Part 2: Target Content Model Design" |

**⚠️ Important:** These are **semicolon-separated strings**, NOT JSON arrays. The Migration Tool's `ToolConfiguration` class splits on semicolons at runtime.

### Source Instance API Discovery Configuration

| Setting | Value | Purpose |
| --- | --- | --- |
| **QuerySourceInstanceApi.Enabled** | `true` | Enable dynamic widget property discovery from KX13 instance |
| **SourceInstanceUri** | `http://localhost:5001/` | KX13 instance URL (accessible during `--pages` step) |
| **Secret** | (generated GUID) | API authentication token; generated during ToolApiController deployment |

**What it does:**
- During `--pages` step, Migration Tool queries KX13 for live widget configurations
- Enables accurate property extraction for custom widgets (InsightCarousel, EventsSlider, etc.)
- Fall back to legacy mode if KX13 unavailable (set `Enabled: false`)

**Prerequisites:**
1. KX13 instance must be running and accessible at SourceInstanceUri
2. ToolApiController deployed to KX13 project (see "ToolApiController Deployment" section below)
3. Secret generated during deployment and configured in appsettings.json

### Field Migration Configuration

| Setting | Purpose | Implemented By |
| --- | --- | --- |
| **CustomMigration.FieldMigrations** | Custom field value & definition transforms | `IFieldMigration` code extensions |

**Enabled Field Migrations:**
- `HtmlSanitization` – HTML cleanup in Description fields
- `MediaAssetExtraction` – File/image field → Content Hub assets
- `TaxonomyReferenceMapping` – Category selector → Taxonomy references
- `DocRelationshipsResolution` – Page relationships → Content item references

### Asset & Media Configuration

| Setting | Value | Purpose |
| --- | --- | --- |
| **AssetRootFolders** | `{ "DefaultMediaLibrary": "/Media" }` | Media library folder mapping during migration |
| **MigrateMediaToMediaLibrary** | `false` | Media files migrate as Content Hub items (not Media Library) |
| **LegacyFlatAssetTree** | `false` | Modern asset hierarchy structure |

### Exclusions Configuration

| Setting | Value | Purpose |
| --- | --- | --- |
| **EntityConfigurations.CMS_Class.ExcludeCodeNames** | `[]` (empty) | No page types excluded; migrate all 79 classes |

⚠️ **Parent Class Rule:** If any class in `ExcludeCodeNames` is a parent of another class being migrated, child classes will fail with "missing dependency ClassInheritsFromClassID". Since you're excluding nothing, this is not a concern.

---

## Per-Site Configuration Templates

Create one configuration file per site using the template below. Copy the master configuration and replace the `TargetWorkspaceName` for each site.

### Template: appsettings.{SITENAME}.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "System": "Warning",
      "Microsoft": "Warning"
    },
    "File": {
      "LogLevel": {
        "Default": "Information",
        "System": "Warning",
        "Microsoft": "Warning"
      },
      "pathFormat": "logs/migration.tool.log",
      "OutputTemplate": "{Timestamp:o} ({SourceContext}) [{Level:u3}] {Message} ({EventId:x8}){NewLine}{Exception}"
    }
  },
  "Settings": {
    "KxConnectionString": "Server=(localdb)\\MSSQLLocalDB;Database=BDO-DB-GWT-TST-EUR;Integrated Security=true;Encrypt=False;",
    "KxCmsDirPath": "C:\\Work\\GWT\\GWT.Web\\CMS",
    "XbyKDirPath": "C:\\Work\\GWT\\GWT.XbyK.Web\\BDO.GWT.GLOBAL",
    "TargetWorkspaceName": "BDO-{SITE}",
    "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-{SITE}.txt",
    
    "ConvertClassesToContentHub": "BDO.Insight",
    "CreateReusableFieldSchemaForClasses": "MetadataFields;HeroFields;LocationFields",
    
    "OptInFeatures": {
      "QuerySourceInstanceApi": {
        "Enabled": true,
        "Connections": [
          {
            "SourceInstanceUri": "http://localhost:5001/",
            "Secret": "your-kx13-api-secret-here"
          }
        ]
      },
      "CustomMigration": {
        "FieldMigrations": "HtmlSanitization;MediaAssetExtraction;TaxonomyReferenceMaping;DocRelationshipsResolution"
      }
    },
    
    "EntityConfigurations": {
      "CMS_Class": {
        "ExcludeCodeNames": []
      },
      "CMS_SettingsKey": {
        "ExcludeCodeNames": []
      }
    },
    
    "AssetRootFolders": {
      "DefaultMediaLibrary": "/Media"
    },
    
    "MigrateOnlyMediaFileInfo": false,
    "MigrateMediaToMediaLibrary": false,
    "LegacyFlatAssetTree": false,
    "UseDeprecatedFolderPageType": false
  }
}
```

---

## Per-Site Configuration Files

Create these 8 files (customize `TargetWorkspaceName` and `MigrationProtocolPath` per site):

### 1. appsettings.demo.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-Demo", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-demo.txt" } }
```

### 2. appsettings.e2e-performance.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-E2E_Performance", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-e2e.txt" } }
```

### 3. appsettings.gwtbdoindia.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-GWTBDOIndiaTeam", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-india.txt" } }
```

### 4. appsettings.gwtexport.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-GWTExport", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-export.txt" } }
```

### 5. appsettings.gwt-tst.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-GWT_TST", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-gwttst.txt" } }
```

### 6. appsettings.integrations.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-Integrations", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-integrations.txt" } }
```

### 7. appsettings.bdowow-com.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-Www.bdowow.com", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-bdowow-com.txt" } }
```

### 8. appsettings.bdowow-global.json
```json
{ "Settings": { "TargetWorkspaceName": "BDO-BDOWOW", "MigrationProtocolPath": "C:\\Work\\GWT\\xperience-by-kentico-kentico-migration-tool\\MigrationProtocol\\protocol-bdowow-global.txt" } }
```

---

## ToolApiController Deployment

**Required For:** Source Instance API Discovery (`QuerySourceInstanceApi.Enabled: true`)

### Step 1: Generate Secret

Generate a secure GUID for API authentication:

```powershell
$secret = [guid]::NewGuid().ToString()
Write-Host "Add this to appsettings.json Secret field:"
Write-Host $secret
```

Example output:
```
a1b2c3d4-e5f6-g7h8-i9j0-k1l2m3n4o5p6
```

### Step 2: Locate ToolApiController File

The controller is bundled with the Migration Tool plugin at:
```
c:\Users\SubhadeepMandal\.vscode\agent-plugins\github.com\Kentico\xperience-by-kentico-kenticopilot\plugins\kentico-kx13-migration\src\KX13.ContentAuditor.CLI\ToolApiController.cs
```

**For .NET Framework 4.8 (alternative):**
```
KX13.NET48.Extensions\ToolApiController.NET48.cs
```

### Step 3: Deploy to KX13 Project

Copy the controller to your KX13 MVC project:
```
C:\Work\GWT\GWT.Web\Controllers\ToolApiController.cs
```

Include the generated secret in the controller:
```csharp
public class ToolApiController : ApiController
{
    private const string ApiSecret = "a1b2c3d4-e5f6-g7h8-i9j0-k1l2m3n4o5p6";
    
    [HttpPost]
    public IHttpActionResult Test(dynamic request)
    {
        if (request.secret != ApiSecret) return Unauthorized();
        return Ok(new { pong = true });
    }
}
```

### Step 4: Register Route

In `App_Start/RouteConfig.cs` or `Startup.cs`:

```csharp
// For ASP.NET MVC 5 WebAPI:
config.Routes.MapHttpRoute(
    name: "ToolApi",
    routeTemplate: "ToolApi/{action}",
    defaults: new { controller = "ToolApi" }
);
```

### Step 5: Build & Start KX13

```powershell
cd C:\Work\GWT\GWT.Web
dotnet build
dotnet run
```

### Step 6: Verify Deployment

Test the API endpoint:

```powershell
$secret = "a1b2c3d4-e5f6-g7h8-i9j0-k1l2m3n4o5p6"
$body = @{ secret = $secret } | ConvertTo-Json
Invoke-WebRequest -Uri "http://localhost:5001/ToolApi/Test" `
  -Method POST `
  -Body $body `
  -ContentType "application/json"

# Expected response:
# {"pong":true}
```

If you get a 200 OK with `{"pong":true}`, deployment is successful.

---

## Validation Checklist

Before running migration, validate your configuration:

### Configuration Syntax
- [ ] JSON is valid (use `json-cli` or online validator)
- [ ] Semicolon-separated strings used (not arrays) for `ConvertClassesToContentHub` and `CreateReusableFieldSchemaForClasses`
- [ ] No trailing commas in JSON
- [ ] All file paths use backslashes `\\` (escaped properly in JSON)

### Infrastructure
- [ ] KxConnectionString connects successfully (`sqlcmd` test)
- [ ] KxCmsDirPath exists and contains `/CMS` directory
- [ ] XbyKDirPath exists and is writable
- [ ] MigrationProtocolPath parent directory can be created by Migration Tool

### Source Instance API
- [ ] KX13 instance running at SourceInstanceUri
- [ ] ToolApiController deployed and `/ToolApi/Test` responds with `{"pong":true}`
- [ ] Secret matches between controller and appsettings.json

### Content Model
- [ ] `ConvertClassesToContentHub` contains only "BDO.Insight"
- [ ] `CreateReusableFieldSchemaForClasses` contains "MetadataFields;HeroFields;LocationFields" (correct order, semicolon-separated)
- [ ] `ExcludeCodeNames` is empty `[]`

### Per-Site Variants
- [ ] 8 appsettings files created (one per site)
- [ ] Each file has unique `TargetWorkspaceName`
- [ ] Each file has unique `MigrationProtocolPath`

---

## Usage

### Run Migration for Single Site

```powershell
cd Migration.Tool.CLI
dotnet run -- --sites --page-types --categories --media-libraries --forms --pages --settings appsettings.demo.json
```

### Run Dry-Run First (Recommended)

```powershell
dotnet run -- --page-types --dry-run --settings appsettings.demo.json
```

Review logs at `logs/migration.tool.log` for warnings before proceeding.

### Run All 8 Sites (Sequential)

```powershell
foreach ($site in @("demo", "e2e-performance", "gwtbdoindia", "gwtexport", "gwt-tst", "integrations", "bdowow-com", "bdowow-global")) {
    Write-Host "Migrating $site..."
    dotnet run -- --sites --page-types --categories --media-libraries --forms --pages --settings "appsettings.$site.json"
}
```

### Run All 8 Sites (Parallel in Background)

```powershell
# Start all migrations in background jobs
$jobs = @()
foreach ($site in @("demo", "e2e-performance", "gwtbdoindia", "gwtexport", "gwt-tst", "integrations", "bdowow-com", "bdowow-global")) {
    $job = Start-Job -ScriptBlock {
        param($site)
        cd "$env:USERPROFILE\Work\GWT\xperience-by-kentico-kentico-migration-tool\Migration.Tool.CLI"
        dotnet run -- --sites --page-types --categories --media-libraries --forms --pages --settings "appsettings.$site.json"
    } -ArgumentList $site
    $jobs += $job
}

# Wait for all to complete
$jobs | Wait-Job
$jobs | Receive-Job
```

---

## Next Steps

1. **Customize Configuration Files**
   - Use the per-site templates above
   - Create 8 appsettings files in `Migration.Tool.CLI/` directory
   - Verify ToolApiController is deployed to KX13

2. **Validate Configuration**
   - Run through the validation checklist
   - Test KX13 connectivity and API endpoint

3. **Build Extension Code**
   - Use `/migrate-content-classes` for `IClassMapping` registrations
   - Use `/migrate-content-widgets` for widget migrations
   - Use `/migrate-content-fields` for field migrations
   - Use `/migrate-content-items` for content item director logic

4. **Dry-Run on Demo Site**
   - Run with `--dry-run` flag
   - Review migration protocol log
   - Verify page type counts and inheritance
   - Iterate on schema until clean

5. **Execute Full Migration**
   - Run against all 8 sites (sequential or parallel)
   - Use `/migrate-content-eval` to generate evaluation reports

---

## Support & Troubleshooting

### Issue: "JSON arrays cause runtime binding error"
**Fix:** Use semicolon-separated strings, not arrays, for `ConvertClassesToContentHub` and `CreateReusableFieldSchemaForClasses`

Example ❌ Wrong:
```json
"ConvertClassesToContentHub": ["BDO.Insight"]
```

Example ✅ Correct:
```json
"ConvertClassesToContentHub": "BDO.Insight"
```

### Issue: "Connection refused" during `--pages`
**Fix:** Verify ToolApiController deployed and KX13 running at SourceInstanceUri. Test with curl/Invoke-WebRequest.

### Issue: "Missing dependency ClassInheritsFromClassID"
**Fix:** Check inheritance hierarchy. If a parent class is excluded, all children fail. Ensure no parents in `ExcludeCodeNames`.

### Issue: Media files not migrating
**Fix:** Verify media files exist in `KxCmsDirPath/media/` and `KxCmsDirPath/files/`. If missing, migration tool will log warnings but continue.

---

**Configuration Version:** 1.0  
**Last Updated:** 2026-08-20  
**Prepared For:** BDO Multi-Site KX13→XbyK Migration

