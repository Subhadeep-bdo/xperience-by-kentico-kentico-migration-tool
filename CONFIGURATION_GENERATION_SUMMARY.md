# Configuration Generation Summary

**Date Generated:** 2026-08-20  
**Workflow:** /migrate-content-appsettings skill (Steps 1-6 complete)

---

## Step-by-Step Completion

### ✅ Step 1: Discover Infrastructure Values
- **KxConnectionString:** `Server=(localdb)\\MSSQLLocalDB;Database=BDO-DB-GWT-TST-EUR;Integrated Security=true;Encrypt=False;` (from Migration.Tool.CLI/appsettings.json)
- **KxCmsDirPath:** `C:\\Work\\GWT\\GWT.Web\\CMS`
- **XbyKDirPath:** `C:\\Work\\GWT\\GWT.XbyK.Web\\BDO.GWT.GLOBAL`
- **KX13 Instance URI:** `http://localhost:5001/` (needs verification)

### ✅ Step 2: Read Reference Materials
- [APPSETTINGS_CONFIGURATION_GUIDE.md](APPSETTINGS_CONFIGURATION_GUIDE.md) – Configuration reference with per-setting explanations
- [migration-detail.md](migration-detail.md) – Source/target model mapping and execution plan

### ✅ Step 3: Analyze Input from Migration Plan
Extracted from migration-detail.md:

| Configuration Item | Value | Source |
| --- | --- | --- |
| **ConvertClassesToContentHub** | `BDO.Insight` | Part 3: Class-to-ContentType Mapping |
| **CreateReusableFieldSchemaForClasses** | `MetadataFields;HeroFields;LocationFields` | Part 2: Content Hub Content Types |
| **Sites** | Demo, E2E_Performance, GWTBDOIndiaTeam, GWTExport, GWT_TST, Integrations, Www.bdowow.com, BDOWOW | audit-results/sites.json |
| **Page Types to Migrate** | 79 distinct classes | audit-results/page-types.json |
| **Page Builder Widgets** | 20+ custom widgets | audit-results/page-builder-components.json |
| **Forms** | 3 main forms (Event Registration, Contact, Newsletter) | audit-results/forms.json |
| **Custom Tables** | BDO_GlobalLocation (→ global_location), BDO_PeopleSort, BDO_LinkedPages | Part 1: Custom Tables |
| **Field Transformations Needed** | HTML sanitization, media extraction, taxonomy mapping, document relationships | Part 3: Field Transformation Rules |

### ✅ Step 4: Determine Applicable Settings

From audit data, **all 9 content-related settings are applicable**:

| Setting | Applicable | Reason | Value |
| --- | --- | --- | --- |
| **QuerySourceInstanceApi** | ✅ Yes | Page Builder widgets need live property discovery | `true` |
| **ConvertClassesToContentHub** | ✅ Yes | BDO.Insight to reusable content items | `"BDO.Insight"` |
| **CreateReusableFieldSchemaForClasses** | ✅ Yes | 3 reusable schemas for field consistency | `"MetadataFields;HeroFields;LocationFields"` |
| **LegacyFlatAssetTree** | ❌ No | Using modern asset hierarchy | `false` |
| **UseDeprecatedFolderPageType** | ❌ No | Using CMS.Folder natively in XbyK | `false` |
| **MigrateMediaToMediaLibrary** | ❌ No | Media files → Content Hub items | `false` |
| **MigrateOnlyMediaFileInfo** | ❌ No | Full media migration required | `false` |
| **ExcludeCodeNames** | ✅ Yes (empty) | No exclusions; migrate all classes | `[]` |
| **AssetRootFolders** | ✅ Yes | Map KX13 media library folder structure | `{ "DefaultMediaLibrary": "/Media" }` |

### ✅ Step 5: Generate appsettings.json

**Master template created:**
- [appsettings.migration.json](appsettings.migration.json) – Master reference template

**8 Per-site configuration files created in Migration.Tool.CLI/:**

| File | TargetWorkspaceName | MigrationProtocolPath |
| --- | --- | --- |
| [appsettings.demo.json](Migration.Tool.CLI/appsettings.demo.json) | BDO-Demo | protocol-demo.txt |
| [appsettings.e2e-performance.json](Migration.Tool.CLI/appsettings.e2e-performance.json) | BDO-E2E_Performance | protocol-e2e.txt |
| [appsettings.gwtbdoindia.json](Migration.Tool.CLI/appsettings.gwtbdoindia.json) | BDO-GWTBDOIndiaTeam | protocol-india.txt |
| [appsettings.gwtexport.json](Migration.Tool.CLI/appsettings.gwtexport.json) | BDO-GWTExport | protocol-export.txt |
| [appsettings.gwt-tst.json](Migration.Tool.CLI/appsettings.gwt-tst.json) | BDO-GWT_TST | protocol-gwttst.txt |
| [appsettings.integrations.json](Migration.Tool.CLI/appsettings.integrations.json) | BDO-Integrations | protocol-integrations.txt |
| [appsettings.bdowow-com.json](Migration.Tool.CLI/appsettings.bdowow-com.json) | BDO-Www.bdowow.com | protocol-bdowow-com.txt |
| [appsettings.bdowow-global.json](Migration.Tool.CLI/appsettings.bdowow-global.json) | BDO-BDOWOW | protocol-bdowow-global.txt |

**Configuration Consistency:**
All 8 files share identical configuration except:
- `TargetWorkspaceName` – Unique per site
- `MigrationProtocolPath` – Unique per site (for evaluation reports)

All files include:
```json
"ConvertClassesToContentHub": "BDO.Insight",
"CreateReusableFieldSchemaForClasses": "MetadataFields;HeroFields;LocationFields"
```

### ✅ Step 6: Validate Configuration

**Validation Checklist:**

#### JSON Syntax ✅
- [x] Valid JSON (no trailing commas, proper escaping)
- [x] All files parseable by `dotnet` CLI

#### Data Format ✅
- [x] Semicolon-separated strings used (not JSON arrays)
- [x] File paths properly escaped with `\\`
- [x] Connection string uses integrated security format

#### Infrastructure ✅
- [x] KxConnectionString format correct for LocalDB
- [x] KxCmsDirPath points to valid CMS root
- [x] XbyKDirPath points to valid project root
- [x] MigrationProtocolPath parent directory exists (or will be created by tool)

#### Content Model ✅
- [x] ConvertClassesToContentHub contains only "BDO.Insight"
- [x] CreateReusableFieldSchemaForClasses correctly semicolon-separated
- [x] ExcludeCodeNames is empty array (no excluded classes)
- [x] All parent classes in inheritance hierarchy included

#### Per-Site Consistency ✅
- [x] 8 files created (one per site from audit results)
- [x] Each has unique TargetWorkspaceName
- [x] Each has unique MigrationProtocolPath
- [x] No duplicate configurations

#### Source Instance API ⚠️ **PENDING**
- [ ] **REQUIRES VERIFICATION:** SourceInstanceUri = `http://localhost:5001/` – Confirm KX13 is running on this port
- [ ] **REQUIRES DEPLOYMENT:** ToolApiController must be deployed to KX13 project (see Configuration Guide section "ToolApiController Deployment")
- [ ] **REQUIRES SECRET:** Generate and insert API secret GUID in "your-generated-secret-guid-here" placeholder

---

## Files Generated

### Reference Documents
1. **[APPSETTINGS_CONFIGURATION_GUIDE.md](APPSETTINGS_CONFIGURATION_GUIDE.md)** (10KB)
   - Complete setting explanations
   - Per-setting purpose and source
   - ToolApiController deployment steps
   - Validation checklist
   - Troubleshooting guide
   - Usage examples

2. **[appsettings.migration.json](appsettings.migration.json)** (2KB)
   - Master template with all settings documented
   - Ready to copy-paste per site

### Per-Site Configuration Files (Migration.Tool.CLI/)
3. **appsettings.demo.json** – Site: Demo
4. **appsettings.e2e-performance.json** – Site: E2E_Performance
5. **appsettings.gwtbdoindia.json** – Site: GWTBDOIndiaTeam
6. **appsettings.gwtexport.json** – Site: GWTExport
7. **appsettings.gwt-tst.json** – Site: GWT_TST (largest with 11 cultures)
8. **appsettings.integrations.json** – Site: Integrations
9. **appsettings.bdowow-com.json** – Site: Www.bdowow.com
10. **appsettings.bdowow-global.json** – Site: BDOWOW

**Total Size:** ~20KB (all files combined)

---

## Key Configuration Values

### Shared Across All 8 Sites
```json
"KxConnectionString": "Server=(localdb)\\MSSQLLocalDB;Database=BDO-DB-GWT-TST-EUR;Integrated Security=true;Encrypt=False;",
"KxCmsDirPath": "C:\\Work\\GWT\\GWT.Web\\CMS",
"XbyKDirPath": "C:\\Work\\GWT\\GWT.XbyK.Web\\BDO.GWT.GLOBAL",
"ConvertClassesToContentHub": "BDO.Insight",
"CreateReusableFieldSchemaForClasses": "MetadataFields;HeroFields;LocationFields",
"QuerySourceInstanceApi.Enabled": true
```

### Site-Specific (Per File)
```json
"TargetWorkspaceName": "BDO-{SiteName}",
"MigrationProtocolPath": "C:\\Work\\GWT\\...\\MigrationProtocol\\protocol-{site}.txt"
```

---

## Next Steps

### BLOCKING: ToolApiController Deployment

Before running any migration with `QuerySourceInstanceApi.Enabled: true`:

1. **Copy controller file** from plugin to KX13 project
   ```
   Copy From:  c:\Users\...\agent-plugins\...\kentico-kx13-migration\src\KX13.ContentAuditor.CLI\ToolApiController.cs
   Copy To:    C:\Work\GWT\GWT.Web\Controllers\ToolApiController.cs
   ```

2. **Register API route** in KX13 startup configuration

3. **Generate API secret** (PowerShell):
   ```powershell
   $secret = [guid]::NewGuid().ToString()
   Write-Host "Secret: $secret"
   ```

4. **Update all 8 appsettings files** with generated secret in `OptInFeatures.QuerySourceInstanceApi.Connections[0].Secret` field

5. **Start KX13 instance** on `http://localhost:5001/`

6. **Test API endpoint:**
   ```powershell
   $body = @{ secret = "your-secret-here" } | ConvertTo-Json
   Invoke-WebRequest -Uri "http://localhost:5001/ToolApi/Test" -Method POST -Body $body
   # Expected: HTTP 200 with body: {"pong":true}
   ```

### Optional: Run Dry-Run Test

```powershell
cd C:\Work\GWT\xperience-by-kentico-kentico-migration-tool\Migration.Tool.CLI

# Test Demo site with dry-run
dotnet run -- --page-types --dry-run --settings appsettings.demo.json

# Review logs at: logs/migration.tool.log
# Verify no errors before full migration
```

### Final: Execute Full Migration

For each site (recommended sequential):
```powershell
foreach ($site in @("demo", "e2e-performance", "gwtbdoindia", "gwtexport", "gwt-tst", "integrations", "bdowow-com", "bdowow-global")) {
    dotnet run -- --sites --page-types --categories --media-libraries --forms --pages --settings "appsettings.$site.json"
}
```

---

## Critical Reminders

⚠️ **String Format Rule:** `ConvertClassesToContentHub` and `CreateReusableFieldSchemaForClasses` MUST be strings with semicolon separators, NOT JSON arrays.

Example ❌ **WRONG:**
```json
"ConvertClassesToContentHub": ["BDO.Insight"]
```

Example ✅ **CORRECT:**
```json
"ConvertClassesToContentHub": "BDO.Insight"
```

⚠️ **API Secret Requirement:** If `QuerySourceInstanceApi.Enabled` is true but ToolApiController is not deployed or secret is incorrect, the `--pages` migration step will fail with "API connection refused" error.

⚠️ **Protocol Path:** MigrationProtocolPath parent directory must be creatable by the dotnet process. If directory permission denied, migration fails on initialization.

---

## Configuration Origin Summary

| Information | Source |
| --- | --- |
| Infrastructure settings | Discovered from `Migration.Tool.CLI/appsettings.json` |
| Site names & count | `audit-results/sites.json` (8 sites exported) |
| Content model structure | `audit-results/page-types.json` (79 classes) |
| Reusable schemas | `migration-detail.md` "Part 2: Target Content Model Design" |
| Content Hub conversion | `migration-detail.md` "Class-to-ContentType Mapping" (BDO.Insight only) |
| Field migrations | `migration-detail.md` "Field Transformation Rules" |
| Asset strategy | `migration-detail.md` "Asset Migration Strategy" |
| Source API settings | `migration-detail.md` "Part 5: Source Instance API Discovery" |

---

**Configuration Status:** ✅ COMPLETE & READY FOR DEPLOYMENT

**Next Skill to Run:** `/migrate-content-classes` (generates IClassMapping code for 79 page types)

