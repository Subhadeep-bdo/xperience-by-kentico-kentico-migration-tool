# KX13 to XbyK Migration Overview Plan

**Source System:** Kentico Xperience 13  
**Target System:** Xperience by Kentico  
**Migration Strategy:** 8 Separate Workspaces (One Per Site)  
**Plan Date:** 2026-08-20

---

## Executive Summary

This migration transforms a complex KX13 multisite ecosystem (8 sites, 79 page types, 174+ pages) into 8 independent XbyK workspaces. The plan prioritizes:

- **BDO.Insight** as a reusable Content Hub content type (key business content)
- **Metadata fields** as shared reusable field schemas (cross-site reuse)
- **Source Instance API Discovery** for Page Builder widgets (dynamic widget configuration)
- **Linked page strategies** to preserve content relationships
- **Media file migration** to Content Hub assets
- **Eight independent workspaces** to isolate per-site configurations, scaling strategies, and team responsibilities

---

## Manual Steps (Pre-Migration)

### Phase 1: Infrastructure & Preparation (Week 1)

1. **Create 8 XbyK Workspaces**
   - Demo → `xbyк-demo-workspace`
   - E2E_Performance → `xbyк-e2e-workspace`
   - GWTBDOIndiaTeam → `xbyк-india-workspace`
   - GWTExport → `xbyк-export-workspace`
   - GWT_TST → `xbyк-tst-workspace`
   - Integrations → `xbyк-integrations-workspace`
   - Www.bdowow.com → `xbyк-bdowow-workspace`
   - BDOWOW → `xbyк-bdowow-global-workspace`

2. **Set Up Content Hub Channels** (per workspace)
   - Create primary website channel
   - Enable media library storage
   - Configure webhook endpoints for preview

3. **Configure Source Instance API**
   - Deploy KX13.Extensions (Net 4.8) or KX13.Extensions (.NET 6+) to KX13 source
   - Expose `ToolApiController` endpoints for Page Builder widget discovery
   - Test connectivity from migration tool to KX13 API

4. **Prepare Source Database**
   - Backup KX13 database
   - Verify media files are accessible (network share or blob storage)
   - Document custom form controls used (MultiRenditionMediaSelector, URLSelector, HtmlAreaControl, etc.)

### Phase 2: Local Testing & Dry Run (Week 1-2)

5. **Run Audit on KX13 Database** ✅ (Already Complete)
   - Content model captured: page-types.json, custom-tables.json, forms.json, page-builder-components.json
   - Sites structure: 8 sites, 79 page types, multiple inheritance hierarchies
   - Review audit results; note inherited page types for reusable schema planning

6. **Execute Dry-Run Migration (Demo Site Only)**
   - Run migration tool against Demo site with test appsettings.json
   - Validate BDO.Insight content → Content Hub items conversion
   - Verify metadata field schema creation
   - Check widget property mappings and linked page handling
   - Resolve any form control conflicts or field transformation errors

---

## Content Model Mapping Overview

### Strategic Conversions

| KX13 Class | Strategy | XbyK Target | Rationale |
| --- | --- | --- | --- |
| **BDO.Insight** | → Content Hub | `Insight` (reusable content item) | Primary business content; used across multiple sites as component reference; enables content reuse and independent lifecycle |
| **BDO.Metadata** (fields) | → Reusable Schema | `MetadataFields` (shared schema) | Common across all pages (Title, Description, TeaserImage, etc.); define once, reference in all page type schemas |
| **BDO.ContentPage** (inherited) | → Page Type Base Schema | `ContentPageBase` | Base fields for inheritance; child classes (BDO.NewsArticle, BDO.BlogPost) extend it |
| **BDO.Insight Category** | → Content Type (Folder-like) | `InsightCategory` | Hierarchical organization; kept as separate content type |
| **Custom Tables** (BDO.GlobalLocation, BDO.LinkedPages) | → Content Hub Reusable Items | Content item types | Site-independent reference data; queried by page rendering logic |
| **Media Assets** (in KX13 media library) | → Content Hub Media Library | Asset media items | Organized by folder; imported with metadata preservation |

### Inheritance Mapping

**KX13 Base Classes → XbyK Page Type Schemas:**
- `CMS.Root` → System page (no custom migration)
- `BDO.ContentSectionPage` → Reusable base schema with inherited fields
- `BDO.ContentPage` → Reusable base schema with core metadata
- All child classes inherit and extend base schema

**XbyK Approach:** Use field reuse and schema composition rather than class inheritance. Each page type schema includes:
1. Core metadata fields (via reference to `MetadataFields` schema)
2. Page-specific fields
3. Hero section fields (as reusable component)

---

## Field Mapping Overview

### Metadata Fields (Shared Schema)

| KX13 Field | Data Type | Form Control | XbyK Field | Handling |
| --- | --- | --- | --- | --- |
| MetadataTitle | text(200) | TextBoxControl | title | Direct text field |
| MetadataDescription | longtext | HtmlAreaControl | description | Rich text field (convert HTML to structured content) |
| MetadataTeaserImage | text(200) | MediaSelectionControl | teaserImage | Media reference to asset |
| MetadataTeaserImageAltText | text(200) | TextBoxControl | teaserImageAlt | Direct text |
| MetadataCanonical | text(2000) | TextBoxControl | canonicalUrl | Direct URL field |
| MetadataOGTitle | text(60) | TextBoxControl | ogTitle | Direct text |
| MetadataOGDescription | text(500) | TextAreaControl | ogDescription | Structured text |
| MetadataOGImage | text(500) | MediaSelectionControl | ogImage | Media reference |
| MetadataNoindex | boolean | CheckBoxControl | metaNoindex | Boolean field |
| MetadataNofollow | boolean | CheckBoxControl | metaNofollow | Boolean field |

### BDO.Insight-Specific Fields

| KX13 Field | Data Type | Form Control | Strategy |
| --- | --- | --- | --- |
| HeroLayout | text | RadioButtonsControl | Map to enum field (options: `bannerImage|banner|hero`) |
| HeroTitle | text(200) | TextBoxControl | Direct text field |
| HeroDescription | text(200) | TextAreaControl | Structured text |
| HeroBackgroundImage | text | MultiRenditionMediaSelector | Media reference; preserve original resolution data as metadata |
| HeroBackgroundImage_Mobile | text | MediaSelectionControl | Media reference (responsive variant) |
| ItemListTitle | text | TextBoxControl | Direct text |
| ItemListFilters | text | MultipleChoiceControl | Parse semicolon-separated values → array field |
| ItemListFeaturedItems | text | Uni_selector | Array of content item references (convert node IDs to item GUIDs) |

### Form Control Transformations

**Custom Controls Requiring IFieldMigration:**

| KX13 Control | Issue | XbyK Solution |
| --- | --- | --- |
| `MultiRenditionMediaSelector` | Stores multiple image resolutions + quality settings | Map to single media field; preserve resolution metadata in custom attributes |
| `Uni_selector` with complex WhereCondition | Filters by culture, publish status, hierarchy | Convert to content item selector; apply filtering in content type schema definition |
| `HtmlAreaControl` (HTML Editor) | Raw HTML content with embedded URLs/media | Use `RichText` field; run HTML sanitization IFieldMigration to remove unsafe tags |
| `RadioButtonsControl` (with options) | CSV options list | Map to `select` or `enum` field with defined options |
| `URLSelector` | URL with page picker | Preserve as URL field; convert page picker selections to absolute URLs or item references |

---

## Widget Transformation Overview

### Key Widgets for Migration

| KX13 Widget | Type | XbyK Equivalent | Mapping Strategy |
| --- | --- | --- | --- |
| BDO.Widget.InsightCarousel | Custom | `BDO.Widget.InsightCarousel` | Keep identifier; query Insight content items from Content Hub; use Source Instance API for dynamic property discovery |
| BDO.Widget.Hero | Custom | `BDO.Widget.Hero` | Map properties: backgroundImage → media reference, title → text, layout → enum |
| BDO.Widget.RichText | Custom | `BDO.Widget.RichText` | Map HTML content → rich text property; apply HTML sanitization |
| BDO.Widget.ImageWithText | Custom | `BDO.Widget.ImageWithText` | Dual media + text properties; preserve layout options |
| BDO.Widget.TabAccordion | Custom | `BDO.Widget.TabAccordion` | Complex nested structure; convert JSON data structure; map form control properties |
| BDO.Widget.KeyContacts | Custom | `BDO.Widget.KeyContacts` | Array of person content item references (linked pages → content items) |
| BDO.Widget.LocalNavigation | Custom | `BDO.Widget.LocalNavigation` | Generated from page hierarchy; recalculate on XbyK tree structure |
| Kentico.FormWidget | System | `Kentico.FormWidget` | Preserve form reference; map form selector property to XbyK form identifier |

### Section Components

| KX13 Section | XbyK Mapping | Property Handling |
| --- | --- | --- |
| Kentico.DefaultSection | `Kentico.DefaultSection` | Direct mapping; no custom properties |
| BDO.Section.TwoColumns | `BDO.Section.TwoColumns` | `containerPadding`, `sectionsGap` → text/enum properties |
| BDO.Section.LocalNavigation | `BDO.Section.LocalNavigation` | `containerPadding` → text/enum property |
| BDO.Section.Container | `BDO.Section.Container` | Single `containerPadding` property |
| BDO.Section.ThreeColumns | `BDO.Section.ThreeColumns` | `containerPadding`, `sectionsGap` properties |

### Source Instance API Integration

**Enable dynamic widget property discovery:**
- KX13 API endpoint: `GET /api/tools/widgets?name=BDO.Widget.InsightCarousel`
- Returns: Property definitions, allowed page types, validation rules
- XbyK Tool Usage: Automatic property mapping during IWidgetMigration; reduce manual form control→XbyK field mapping
- Configuration: Set `EnableSourceInstanceApiDiscovery: true` in appsettings.json

---

## Page Relationship Overview

### Linked Page Strategy

**KX13 Linked Pages Table:** `BDO_LinkedPages` (custom table tracking cross-site page references)

**XbyK Approach:**

| Strategy | Use Case | Implementation |
| --- | --- | --- |
| **Materialize** | Linked page content is always needed on display | Convert linked page node ID to content item reference (IContentItemReference); store in array field |
| **Store Reference** | Linked page URL is stored but not always used | Store as URL string field or `IContentItemReference` (lazy-loaded); preserve node GUID → item GUID mapping |
| **Store GUID Only** | Keep reference minimal; resolve at render time | Store GUID in text field; lookup in Content Hub at page render time |
| **Drop Orphaned** | Linked page no longer exists or is deprecated | IContentItemDirectorBase: skip migration for deprecated nodes; log warnings |

**Implementation via IContentItemDirectorBase:**
```
Override CheckAndModifyConfigurationBefore:
- if (sourceNode.LinkedNodeId != null && sourceNode.LinkedNodeSiteId != null)
  - Lookup target content item by source node GUID
  - Create IContentItemReference or store URL
```

### Linked Content Resolution

**Media Relationships:**
- KX13: Media URLs stored as text paths (e.g., `/getmedia/guid/filename.ext`)
- XbyK: Convert to Content Hub asset references
- IFieldMigration: Parse media URLs → extract asset GUID → create `IAssetReference`

**Page References:**
- KX13: Node IDs, Node GUIDs, page picker control data
- XbyK: Content item GUIDs or ItemIDs
- IContentItemDirectorBase: Map KX13 Node ID → XbyK Item GUID using migration context

---

## Execution Summary

### CLI Parameters & Site-Specific Runs

| Run # | Site Name | Command | Status | Notes |
| --- | --- | --- | --- | --- |
| 1 | Demo | `dotnet Migration.Tool.CLI run --settings appsettings.demo.json` | 🔄 Ready | Dry-run first; validate Insight conversion |
| 2 | E2E_Performance | `dotnet Migration.Tool.CLI run --settings appsettings.e2e.json` | 🔄 Ready | Small dataset; test performance tools |
| 3 | GWTBDOIndiaTeam | `dotnet Migration.Tool.CLI run --settings appsettings.india.json` | ⏳ Queued | Single culture (en-GB); faster migration |
| 4 | GWTExport | `dotnet Migration.Tool.CLI run --settings appsettings.export.json` | ⏳ Queued | Multi-culture (en-GB, ru-RU) |
| 5 | GWT_TST | `dotnet Migration.Tool.CLI run --settings appsettings.tst.json` | ⏳ Queued | Largest dataset (11 cultures); test API capacity |
| 6 | Integrations | `dotnet Migration.Tool.CLI run --settings appsettings.integrations.json` | ⏳ Queued | Multi-culture (nl-NL, en-GB) |
| 7 | Www.bdowow.com | `dotnet Migration.Tool.CLI run --settings appsettings.bdowow.json` | ⏳ Queued | 2 cultures (en-GB, lt-LT) |
| 8 | BDOWOW | `dotnet Migration.Tool.CLI run --settings appsettings.bdowow-global.json` | ⏳ Queued | 2 cultures (en-GB, lt-LT) |

### Execution Flow

1. **Sequential Migration** (One workspace at a time)
   - Reason: Isolate failures; understand blockers per site
   - Duration estimate: 2-4 hours per site (depends on content volume)
   - Parallel cleanup & validation while next migration runs

2. **Post-Migration Validation**
   - Spot-check Insight content: metadata, widgets, linked pages
   - Validate media asset imports: all images/documents present in Content Hub
   - Test Page Builder page rendering: sections load, widgets display correctly
   - Verify form submissions: Kentico.FormWidget buttons functional

---

## Operational Notes

### Database Considerations

- **KX13 Source:** Maintain connection during all 8 migrations (API calls for widget discovery, linked page lookup)
- **XbyK Targets:** Separate databases per workspace (8 independent databases)
- **Backup:** Full backups of both source and target before each run

### Scaling & Performance

- **Large Site (GWT_TST):** 11 cultures, high page count
  - Consider: Split migration into phases (culture by culture) if API timeouts occur
  - Monitor: Memory usage during Insight content item batch insert

- **API Discovery:** Source Instance API calls on every widget transformation
  - Cache widget definitions locally if repeated calls detected
  - Implement retry logic for transient failures

### Risk Mitigation

| Risk | Mitigation | Fallback |
| --- | --- | --- |
| Linked page references break | Map all node GUIDs to item GUIDs before migration; validate mappings | Store as URL strings instead of item references |
| Media files not found | Verify all media library paths accessible; run media export test | Skip missing media; log errors; manually re-import later |
| Custom form controls fail | Test form control transformations in dry-run; generate IFieldMigration code pre-migration | Flatten custom control data to simpler fields (e.g., HTML → plain text) |
| Widget properties unmapped | Enable Source Instance API discovery; pre-populate widget property definitions | Manually map remaining properties via IWidgetMigration |

### Post-Migration Tasks (Per Workspace)

1. **Content Validation** (2-3 days per workspace)
   - Sample 10-20 Insight pages: verify metadata, widgets, images
   - Check linked page references: verify URLs/references resolve correctly
   - Test forms: submit test data to Kentico.FormWidget; check notification emails

2. **Performance Tuning**
   - Monitor query performance: optimize content queries (Insight carousel queries)
   - Adjust cache settings: page builder component caching
   - Load testing: simulate typical traffic patterns

3. **URL Rewriting & Redirects**
   - Map old KX13 URLs to new XbyK URLs
   - Set up HTTP redirects (301) for SEO preservation
   - Update internal links & sitemaps

4. **QA & UAT Sign-Off**
   - Content team reviews: metadata, SEO fields, OG tags
   - Marketing team validates: widget layouts, imagery, CTAs
   - Technical team checks: API integrations, form submissions, performance

5. **Launch Preparation**
   - DNS switching (if separate infrastructure)
   - CDN configuration for media assets
   - SSL certificate deployment
   - Analytics/tracking code setup

---

## Team Responsibilities & Timeline

| Phase | Team | Duration | Deliverable |
| --- | --- | --- | --- |
| **Preparation** | DevOps + Solutions Architect | 1 week | 8 XbyK workspaces created; API connectivity verified |
| **Dry-Run** | Dev + QA | 1 week | Demo site migrated; blockers identified and resolved |
| **Bulk Migration** | Automation + Dev Support | 2-3 weeks | All 8 sites migrated; data integrity confirmed |
| **Validation** | QA + Content Team | 2-3 weeks | Spot-checks passed; no critical data loss |
| **Launch Prep** | DevOps + Dev + Marketing | 1 week | URLs mapped; redirects in place; monitoring ready |
| **Go-Live** | DevOps | 1 day | DNS switch; traffic verified; rollback plan ready |

---

## Next Steps

1. ✅ Review this overview plan with stakeholders
2. → Read `migration-detail.md` for technical configuration details
3. → Prepare `appsettings.json` files for each workspace (template in detail plan)
4. → Develop `IClassMapping`, `IFieldMigration`, `IWidgetMigration` extension code
5. → Execute dry-run migration on Demo site
6. → Resolve blockers; refine extension code
7. → Execute bulk migration (Run 1-8 in sequence)
8. → Perform validation; launch

---

**Document Version:** 1.0  
**Last Updated:** 2026-08-20  
**Status:** Ready for Technical Review
