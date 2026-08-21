# KX13 to XbyK Migration - Technical Detail Plan

**Date:** 2026-08-20  
**Target:** 8 Separate XbyK Workspaces  
**Focus:** BDO.Insight as Content Hub, Metadata as Reusable Schema, Source Instance API Discovery

---

## Part 1: Source Content Model

### Page Type Inventory

**System/Base Classes:**

| Class Name | ClassID | Purpose | Fields | Inheritance |
| --- | --- | --- | --- | --- |
| CMS.Root | 1095 | Root node | None (metadata enabled) | None |
| CMS.Folder | 5383 | Generic folder | None | None |
| BDO.ContentSectionPage | - | Base for sections | Metadata (Title, Desc, Image, OG, SEO) | Inherited by BDO.SectionNews, BDO.SectionServices, etc. |
| BDO.ContentPage | - | Base for pages | Metadata fields + common page fields | Inherited by BDO.NewsArticle, BDO.BlogPost, BDO.Insight |

**Content Page Types (Selection):**

| Class Name | ClassID | Table | Custom Fields | Inherits From | Uses Widgets | Sites |
| --- | --- | --- | --- | --- | --- | --- |
| **BDO.Insight** | 5498 | BDO_Insight | 50+ (Hero, ItemList, Content fields) | BDO.ContentPage | Yes (Hero, Carousel, RichText) | All 8 sites |
| BDO.NewsArticle | 5508 | BDO_NewsArticle | 40+ (Metadata, Hero, ItemList) | BDO.ContentPage | Yes | All 8 |
| BDO.HomePage | - | BDO_HomePage | 45+ (Hero, Trending, Featured) | BDO.ContentPage | Yes (Carousel, Slider) | All 8 |
| BDO.ServiceArea | - | BDO_ServiceArea | 30+ (Service, KeyContacts) | BDO.ContentPage | Yes (Tab, Contacts) | All 8 |
| BDO.Industry | - | BDO_Industry | 25+ (Category, Services) | BDO.ContentPage | Yes (Carousel) | All 8 |
| BDO.BlogPost | - | BDO_BlogPost | 35+ (Metadata, Hero) | BDO.ContentPage | Yes (RichText, Gallery) | Demo, E2E, Others |
| BDO.Event | - | BDO_Event | 50+ (Hero, Dates, Registrations) | BDO.ContentPage | Yes (Hero, Form) | All 8 |
| BDO.Deal | - | BDO_Deal | 20+ (Title, Description, Value) | BDO.ContentPage | Yes (RichText) | Demo, TST, Others |
| BDO.LegalPage | - | BDO_LegalPage | Minimal (Title, Content) | BDO.ContentPage | Yes (RichText) | All 8 |
| BDO.Person | - | BDO_Person | 25+ (Bio, Contact, Image) | BDO.ContentPage | Yes (Form) | All 8 |

**Total Page Types:** 79 distinct classes (including folders, navigation items, galleries, etc.)

### Custom Tables (Content Hub Candidates)

| Table | ClassID | Purpose | Record Count | Key Fields | Strategy |
| --- | --- | --- | --- | --- | --- |
| BDO_GlobalLocation | 5572 | Office locations (worldwide) | ~50-100 | Title, Address, Lat/Long, Region | → Content Type: `GlobalLocation` (reusable items) |
| BDO_PeopleSort | 5588 | Sort/order for people displays | ~200 | PeopleNodeGuid, SortOrder, CultureCode | → Custom table data; migrate to order lists or skip (recalculate in XbyK) |
| BDO_LinkedPages | 5589 | Cross-page & cross-site links | ~500 | LinkedPageNodeId, TargetNodeId, ClassType | → IContentItemDirectorBase processor; map to content item references |

### Forms Used in Content

| Form Name | FormID | Associated Class | Fields | Strategy |
| --- | --- | --- | --- | --- |
| BDOEventTemplate_DoNotModify | 8 | BDO.EventRegistrationForm | Name, Email, Questions (7 fields) | → Keep in XbyK Form Builder; map field types |
| BDO Contact Form | - | BDO.Contact | Name, Email, Message, Subject | → Kentico.FormWidget equivalent |
| BDO Newsletter Subscribe | - | BDO.Subscribe | Email, Preferences (checkboxes) | → Form Builder form |

### Page Builder Components Used

**Sections (used in Insight & other pages):**
- `Kentico.DefaultSection` (full width, single column)
- `BDO.Section.TwoColumns` (properties: containerPadding, sectionsGap)
- `BDO.Section.LocalNavigation` (sidebar nav)
- `BDO.Section.Container` (wrapper)
- `BDO.Section.ThreeColumns` (3-column grid)
- `BDO.Section.TwoThirdOneThird` (asymmetric layout)
- `BDO.Section.OneThirdTwoThird` (reverse asymmetric)
- `BDO.Section.FourColumns`, `FiveColumns` (multi-column)

**Widgets Used in Insight (most complex):**
1. **BDO.Widget.Hero** - Banner with image, title, description, CTA button
2. **BDO.Widget.InsightCarousel** - Carousel of Insight items (content query)
3. **BDO.Widget.RichText** - HTML rich text editor content
4. **BDO.Widget.KeyContacts** - Related person items (linked content)
5. **BDO.Widget.EditorsPick** - Featured/curated content selector
6. **BDO.Widget.ImageWithText** - Image + text block
7. **BDO.Widget.LocalNavigation** - Hierarchical page tree navigation
8. **BDO.Widget.FlexibleContent** - Nested component container
9. **BDO.Widget.TabAccordion** - Tabbed/accordion interface
10. **BDO.Widget.Button** - CTA button (link, label, style)
11. **BDO.Widget.RelatedContentCarousel** - Related articles carousel
12. **BDO.Widget.Faq** - FAQ accordion from linked pages
13. **Kentico.FormWidget** - Form submission widget

---

## Part 2: Target Content Model Design

### Content Hub Content Types (Reusable Schemas)

#### 1. Metadata Schema (Reusable Fields)

Used by: All page types

```
Content Type: MetadataFields (Reusable Schema)

Fields:
- title: text field, required, max 200 chars
- description: rich_text field, nullable
- teaserImage: asset reference, nullable
- teaserImageAltText: text field, max 200 chars
- canonicalUrl: url field, nullable
- ogTitle: text field, max 60 chars
- ogDescription: text field, max 500 chars
- ogImage: asset reference, nullable
- metaNoindex: boolean, default false
- metaNofollow: boolean, default false

Used By: All content pages (Insight, NewsArticle, BlogPost, etc.)
Reference Mode: Schema composition (fields included in child schemas)
```

#### 2. BDO.Insight Content Type (Primary - Content Hub Item)

**Identifier:** `bdo_insight`  
**Type:** Reusable (can be queried, referenced, displayed independently)  
**Inheritance:** Uses MetadataFields schema

```
Fields:

[Metadata Fields - Inherited/Composed]
- title (from MetadataFields)
- description (from MetadataFields)
- teaserImage (from MetadataFields)
- canonicalUrl (from MetadataFields)
- ogMetadata (from MetadataFields)

[Insight-Specific Fields]
- heroLayout: select {
    options: ["bannerImage", "banner", "hero"],
    required: false
  }
- heroTitle: text(200)
- heroDescription: text(200)
- heroBackgroundImage: asset reference
- heroBackgroundImageAltText: text(200)
- heroMobileImage: asset reference
- heroCTAButtonType: select { options: ["none", "primary", "secondary", "tertiary"] }
- heroCTAButtonText: text(200)
- heroCTAButtonUrl: url

- itemListTitle: text(200)
- itemListDescription: text(200)
- itemListFilters: select multiple {
    options: ["contentType", "businessLine", "serviceArea", "industryCategory"],
    default: ["contentType", "businessLine", "industryCategory"]
  }
- itemListFeaturedItems: asset reference array (links to other Insight items)
- itemListAdvancedSearchDescription: text
- itemListAdvancedSearchLinkUrl: url

[Page Builder Content]
- pageBuilderSections: structured data (JSON) - serialized Page Builder sections/widgets
- linkedPages: content item reference array (resolved via BDO.LinkedPages mapping)

[SEO & System]
- metaNoindex, metaNofollow (from MetadataFields)
- includeInSitemap: boolean, default true
```

#### 3. GlobalLocation Content Type (Custom Table Conversion)

Used by: Service Area pages, Locations sections

```
Content Type: global_location

Fields:
- title: text(100), required
- address1: text(200)
- address2: text(200)
- city: text(100)
- state: text(100)
- country: text(255)
- postalCode: text(20)
- latitude: decimal(6)
- longitude: decimal(6)
- region: select { options: ["Americas", "EMEA", "Asia Pacific"] }
- pinColour: select { options: ["Red", "Emerald"] }
- memberfirmId: integer
- url: url
- createdBy: integer
- createdWhen: datetime
- modifiedBy: integer
- modifiedWhen: datetime
- displayOrder: integer
```

#### 4. Other Reusable Content Types

| Type | Fields | Usage |
| --- | --- | --- |
| NewsArticle | Metadata + Hero + RichText | News listing pages |
| BlogPost | Metadata + Hero + Tags + RelatedPosts | Blog sections |
| Event | Metadata + EventDates + Registration + Hero | Event listings |
| Person | Name + Bio + Image + ContactInfo | People directories, Author info |
| ServiceArea | Name + Description + Parent Service + KeyContacts | Service hierarchies |
| Industry | Name + Description + Parent + LinkedServices | Industry categories |

---

## Part 3: Content Model Mapping (KX13 → XbyK)

### Class-to-ContentType Mapping

```
KX13 Page Type                 → XbyK Content Type         → Migration Handler
─────────────────────────────────────────────────────────────────────────────
BDO.Insight                    → bdo_insight               → IClassMapping (convert to Content Hub)
BDO.NewsArticle                → news_article              → IClassMapping
BDO.BlogPost                   → blog_post                 → IClassMapping
BDO.HomePage                   → home_page                 → IClassMapping
BDO.Event                      → event                     → IClassMapping
BDO.ServiceArea                → service_area              → IClassMapping
BDO.Person                     → person                    → IClassMapping
BDO.Deal                       → deal                      → IClassMapping
BDO.Industry                   → industry                  → IClassMapping
BDO.InsightCategory            → insight_category          → IClassMapping
BDO.SectionNews, .SectionAbout → (skip - hierarchical only) → IContentItemDirectorBase (drop)
BDO.GlobalLocation (custom)    → global_location           → IClassMapping
BDO.LinkedPages (custom)       → (reference resolution)    → IContentItemDirectorBase (post-process)
```

### Field Transformation Rules

#### Category 1: Direct Mapping (No Transform)

| KX13 Field | KX13 Type | XbyK Field | XbyK Type |
| --- | --- | --- | --- |
| MetadataTitle | text(200) | title | text |
| MetadataCanonical | text(2000) | canonicalUrl | url |
| HeroTitle | text(200) | heroTitle | text |
| HeroLayout | text | heroLayout | select |
| ItemListTitle | text(200) | itemListTitle | text |
| IncludeInSitemap | boolean | includeInSitemap | boolean |

#### Category 2: Rich Text Transform

| KX13 Field | Form Control | Issue | Transform |
| --- | --- | --- | --- |
| MetadataDescription | HtmlAreaControl | Raw HTML with unsafe tags, embedded URLs | IFieldMigration: Sanitize HTML (remove scripts, unsafe attrs); extract media URLs → asset references |
| HeroDescription | TextAreaControl | Plain text (no HTML) | Convert to rich_text; preserve line breaks |
| Content fields | HtmlAreaControl (various) | Embedded media URLs, relative paths | IFieldMigration: Parse HTML → replace KX13 media paths with Content Hub asset GUIDs |

**IFieldMigration Sample Code:**
```csharp
public class HtmlSanitizationFieldMigration : IFieldMigration
{
    public async Task<IMigrationValue> Migrate(
        FieldDefinition definition,
        IMigrationValue sourceValue,
        IContentItemMigrationContext context)
    {
        if (sourceValue?.Value is not string html) return sourceValue;
        
        // Remove script tags, sanitize attributes
        var sanitized = HtmlSanitizer.Sanitize(html);
        
        // Convert media URLs: /getmedia/guid/file.jpg → [asset:guid]
        var withAssets = Regex.Replace(sanitized,
            @"/getmedia/([a-f0-9\-]+)/",
            match => $"[asset:{match.Groups[1].Value}]");
        
        return new StringMigrationValue(withAssets);
    }
}
```

#### Category 3: Media Reference Transform

| KX13 Field | Form Control | Data Format | XbyK Mapping | Code Path |
| --- | --- | --- | --- | --- |
| MetadataTeaserImage | MediaSelectionControl | Text path `/getmedia/guid/file.jpg` | Asset reference | IFieldMigration: Extract GUID → lookup in migrated assets |
| HeroBackgroundImage | MultiRenditionMediaSelector | JSON {guid, resolutions: []} | Asset reference + metadata | IFieldMigration: Parse JSON; use highest resolution GUID |
| HeroMobileImage | MediaSelectionControl | Text path | Asset reference | IFieldMigration: Direct GUID extraction |

**Asset Migration Strategy:**
1. Export KX13 media library to temporary storage
2. Import assets to XbyK Content Hub Media Library (preserve folder structure)
3. Create mapping table: KX13 MediaID/GUID → XbyK Asset GUID
4. During field migration, reference mapping table to resolve assets

#### Category 4: Reference/Selector Transform

| KX13 Field | Form Control | Data | Issue | IFieldMigration |
| --- | --- | --- | --- | --- |
| ItemListFeaturedItems | Uni_selector | Node IDs (semicolon-separated) | Multiple page references across cultures; format: "nodeId1;nodeId2" | Parse IDs; lookup in node→content-item mapping; return array of IContentItemReference |
| KeyContacts | Person selector | Node IDs array | Linked person content items | Same as above; create references to Person content items |
| ParentService | Page picker | Single Node ID | Hierarchy reference | Lookup mapping; create single IContentItemReference |

**IFieldMigration: Reference Resolution**
```csharp
public class PageSelectorFieldMigration : IFieldMigration
{
    private readonly INodeToContentItemMapRepository _mapping;
    
    public async Task<IMigrationValue> Migrate(
        FieldDefinition definition,
        IMigrationValue sourceValue,
        IContentItemMigrationContext context)
    {
        if (sourceValue?.Value is not string nodeIds) return sourceValue;
        
        var ids = nodeIds.Split(';');
        var references = new List<ContentItemReference>();
        
        foreach (var nodeId in ids)
        {
            if (int.TryParse(nodeId.Trim(), out var id))
            {
                var itemGuid = await _mapping.GetContentItemGuid(id);
                if (itemGuid.HasValue)
                    references.Add(new ContentItemReference(itemGuid.Value));
            }
        }
        
        return new ContentItemReferenceArrayMigrationValue(references);
    }
}
```

#### Category 5: Options/Select Transform

| KX13 Field | Form Control | Options | XbyK Field | Mapping |
| --- | --- | --- | --- | --- |
| HeroCallToActionButtonType | RadioButtonsControl | "none\|primary\|secondary\|tertiary" | heroCTAButtonType | Direct; parse options CSV → select enum |
| GlobalLocationRegion | DropDownListControl | "1;Americas\n2;EMEA\n3;Asia Pacific" | region | Parse semicolon-separated; use labels as values |
| ItemListFilters | MultipleChoiceControl | "contentType;businessLine;serviceArea\|industryCategory" | itemListFilters | Parse; create multiselect array |

#### Category 6: Boolean & Flag Transform

| KX13 Field | Type | Default | XbyK Mapping | Logic |
| --- | --- | --- | --- | --- |
| MetadataNoindex | boolean | Null | metaNoindex | Direct; False if Null |
| MetadataNofollow | boolean | Null | metaNofollow | Direct; False if Null |
| IncludeInSitemap | boolean | true | includeInSitemap | Direct; preserve default |
| ShowTitle | boolean | True | showTitle | Direct |
| ItemListFilteringEnabled | boolean | true | itemListFilteringEnabled | Direct |

### Inherited Field Handling

**KX13 Inheritance Model:**
- BDO.ContentSectionPage → BDO.SectionNews, BDO.SectionAbout, BDO.SectionServices
- BDO.ContentPage → BDO.NewsArticle, BDO.Insight, BDO.BlogPost, BDO.Event, BDO.Deal
- Inheritance is class-based; fields cascade to child classes

**XbyK Approach: Schema Composition**

Instead of class inheritance, use content type field composition:

1. **MetadataFields** (reusable schema) includes:
   - All `Metadata*` fields
   - SEO fields: metaNoindex, metaNofollow, includeInSitemap

2. **HeroFields** (reusable schema) includes:
   - heroLayout, heroTitle, heroDescription
   - heroBackgroundImage, heroCTAButton*

3. **ContentPageBaseFields** (reusable schema) includes:
   - MetadataFields
   - HeroFields
   - Common page fields (publishedDate, author, etc.)

4. **Specific Content Types** extend with their own fields:
   - `bdo_insight` = ContentPageBaseFields + Insight-specific
   - `news_article` = ContentPageBaseFields + NewsArticle-specific
   - etc.

**IClassMapping Implementation:**
```csharp
public class InsightClassMapping : IClassMapping
{
    public string SourceClassName => "BDO.Insight";
    public string TargetContentTypeName => "bdo_insight";
    
    public async Task<ContentItemMigrationModel> Map(
        ContentItemMigrationModel model,
        IClassMappingContext context)
    {
        // Maps BDO.Insight fields to bdo_insight content type
        // Handles metadata composition, hero fields, insight-specific fields
        model.Data["title"] = model.GetFieldValue("MetadataTitle");
        model.Data["description"] = model.GetFieldValue("MetadataDescription");
        model.Data["heroLayout"] = model.GetFieldValue("HeroLayout");
        // ... additional mappings
        
        return await Task.FromResult(model);
    }
}
```

---

## Part 4: Linked Pages & Cross-Reference Handling

### BDO.LinkedPages Custom Table

Structure:
```
LinkedPagesID (int)
LinkedPagesName (string)
LinkedPagesCodeName (string)
LinkedPagesCultureCode (string)
LinkedPagesNodeId (int) ← Source page node ID
LinkedPagesPeopleID (string) ← Target person ID (optional)
LinkedPagesNodeGUID (guid) ← Source page GUID
LinkedPagesSiteID (int)
LinkedPagesClassname (string) ← Target class (e.g., BDO.Person, BDO.Insight)
LinkedPagesAfterImportNodeIDs (int) ← Post-migration: target XbyK item ID
LinkedPagesAfterImportPeopleIDs (string) ← Post-migration: target person item ID
```

### Linked Page Migration Strategy

#### Strategy 1: Materialize (Recommended for Insight Linking)

**When:** Linked content is always displayed (e.g., related insights, key contacts)

**Implementation:**

1. **IContentItemDirectorBase: Pre-Process Phase**
   ```csharp
   override CheckAndModifyConfigurationBefore(...)
   {
       if (node.ClassName == "BDO.Insight")
       {
           var linkedPages = linkedPageRepository.GetLinkedPagesFor(node.NodeID);
           foreach (var linked in linkedPages)
           {
               var targetItem = await context.Lookup(linked.LinkedPagesNodeId);
               node.Fields["linkedInsights"] = linkedItems; // Array reference
           }
       }
   }
   ```

2. **Schema:** Add to `bdo_insight`
   ```
   linkedInsights: content item reference array
   ```

#### Strategy 2: Store GUID for Lazy Resolution

**When:** Linked content is optional; fetched on-demand at render

**Implementation:**

```csharp
override CheckAndModifyConfigurationBefore(...)
{
    var linkedPages = linkedPageRepository.GetLinkedPagesFor(node.NodeID);
    var guids = linkedPages.Select(x => x.LinkedPagesNodeGUID).ToList();
    node.Fields["linkedPageGuids"] = string.Join(";", guids);
}
```

Schema:
```
linkedPageGuids: text (semicolon-separated GUIDs)
```

Render-time resolution:
```csharp
// In rendering component
var guids = contentItem.Fields["linkedPageGuids"]?.Split(';');
foreach (var guid in guids)
{
    var linkedItem = await contentHub.GetItemByGuid(guid);
    // Display linked item
}
```

#### Strategy 3: URL Storage (for External/Deprecated Links)

**When:** Link target might not exist in XbyK or is external URL

**Implementation:**

```csharp
override CheckAndModifyConfigurationBefore(...)
{
    var linkedPages = linkedPageRepository.GetLinkedPagesFor(node.NodeID);
    var urls = new List<string>();
    
    foreach (var linked in linkedPages)
    {
        try
        {
            var targetItem = await context.Lookup(linked.LinkedPagesNodeId);
            urls.Add(targetItem.RenderedUrl ?? "");
        }
        catch
        {
            // Fallback: construct URL from node info
            urls.Add($"/nodes/{linked.LinkedPagesNodeId}");
        }
    }
    
    node.Fields["linkedPageUrls"] = string.Join("|", urls);
}
```

Schema:
```
linkedPageUrls: text (pipe-separated URLs)
```

### Media Linking

**KX13 Storage:** Media URLs embedded in HTML or stored in text fields
- Format: `/getmedia/[guid]/[filename]`
- Example: `/getmedia/a1b2c3d4-e5f6-7890-abcd-ef1234567890/hero-image.jpg`

**Migration Strategy:**

1. **Extract GUID from URL** via regex
2. **Lookup in Media Migration Log** (created during asset import phase)
3. **Replace URL with Asset Reference** in rich text fields

**IFieldMigration: Media URL Replacement**
```csharp
public class MediaUrlReplacementFieldMigration : IFieldMigration
{
    private readonly IMediaGuidMapping _mediaMapping;
    
    public async Task<IMigrationValue> Migrate(
        FieldDefinition definition,
        IMigrationValue sourceValue,
        IContentItemMigrationContext context)
    {
        if (sourceValue?.Value is not string content) return sourceValue;
        
        // Pattern: /getmedia/{guid}/{filename}
        var pattern = @"/getmedia/([a-f0-9\-]+)/";
        var replaced = Regex.Replace(content, pattern, match =>
        {
            var oldGuid = match.Groups[1].Value;
            var newGuid = _mediaMapping.MapGuid(oldGuid);
            return $"/api/assets/{newGuid}/";
        });
        
        return new StringMigrationValue(replaced);
    }
}
```

---

## Part 5: Widget Transformation (IWidgetMigration)

### Widget Property Mapping Table

#### BDO.Widget.InsightCarousel

```
KX13 Properties:
- title: text → XbyK: title
- description: text → XbyK: description
- featuredInsights: node IDs → XbyK: featuredInsights (content item ref array)
- filters: text (options) → XbyK: filters (select multi)
- filteringEnabled: boolean → XbyK: filteringEnabled
- seeAllLinkText: text → XbyK: seeAllLinkText
- seeAllLinkUrl: URL → XbyK: seeAllLinkUrl
- backgroundImages: array → XbyK: backgroundImages (asset ref array)
```

**IWidgetMigration Implementation:**
```csharp
public class InsightCarouselWidgetMigration : IWidgetMigration
{
    public string SourceWidgetName => "BDO.Widget.InsightCarousel";
    public string TargetWidgetName => "BDO.Widget.InsightCarousel"; // Identifier unchanged
    
    public async Task<WidgetMigrationModel> Migrate(
        WidgetMigrationModel widget,
        IWidgetMigrationContext context)
    {
        // Map featured insights node IDs to content item references
        if (widget.Properties.TryGetValue("featuredInsights", out var nodeIdList))
        {
            var insightRefs = await ResolveNodeIdsToContentItems(nodeIdList as string[], context);
            widget.Properties["featuredInsights"] = insightRefs;
        }
        
        // Resolve background images
        if (widget.Properties.TryGetValue("backgroundImages", out var imagesList))
        {
            var assetRefs = await ResolveMediaUrls(imagesList as string[], context);
            widget.Properties["backgroundImages"] = assetRefs;
        }
        
        return await Task.FromResult(widget);
    }
    
    private async Task<List<ContentItemReference>> ResolveNodeIdsToContentItems(
        string[] nodeIds, IWidgetMigrationContext context)
    {
        var refs = new List<ContentItemReference>();
        foreach (var nodeId in nodeIds)
        {
            if (int.TryParse(nodeId, out var id))
            {
                var itemGuid = await context.Lookup(id); // Returns content item GUID
                refs.Add(new ContentItemReference(itemGuid));
            }
        }
        return refs;
    }
}
```

#### BDO.Widget.Hero

```
Property Mapping:
- layout: enum → layout (select: bannerImage|banner|hero)
- title: text → title
- description: text → description
- backgroundImage: media path → backgroundImage (asset ref)
- ctaButtonType: enum → ctaButtonType
- ctaButtonText: text → ctaButtonText
- ctaButtonUrl: URL → ctaButtonUrl
```

#### BDO.Widget.RichText

```
Property Mapping:
- content: HTML (raw) → content (rich_text)
  Transform: Apply HtmlSanitizationFieldMigration
```

#### BDO.Widget.KeyContacts

```
Property Mapping:
- contacts: node IDs (semicolon-separated) → contacts (content item ref array)
  Transform: Parse IDs; lookup Person items
```

#### Kentico.FormWidget

```
Property Mapping:
- formIdentifier: node ID → formIdentifier (form ref)
  Transform: Lookup form by source ID; map to XbyK form GUID
  Note: Forms must be migrated separately before page builder content
```

### Source Instance API Discovery

**Enable per widget**: Query KX13 API to dynamically discover widget properties

**Configuration (appsettings.json):**
```json
{
  "SourceInstanceApiDiscovery": {
    "Enabled": true,
    "ApiBaseUrl": "https://kx13-source.example.com",
    "ApiKey": "your-api-key",
    "CacheWidgetDefinitions": true,
    "CacheDuration": 3600
  }
}
```

**IWidgetMigration: With API Discovery**
```csharp
public class DynamicWidgetMigration : IWidgetMigration
{
    private readonly ISourceInstanceApiClient _apiClient;
    
    public async Task<WidgetMigrationModel> Migrate(
        WidgetMigrationModel widget,
        IWidgetMigrationContext context)
    {
        // Query API for widget property definitions
        var definition = await _apiClient.GetWidgetDefinition(widget.Name);
        
        // For each property in definition, validate & transform
        foreach (var propDef in definition.Properties)
        {
            if (!widget.Properties.ContainsKey(propDef.Name))
                continue;
                
            switch (propDef.Type)
            {
                case "assetReference":
                    widget.Properties[propDef.Name] = 
                        await ResolveAssetReference(widget.Properties[propDef.Name]);
                    break;
                case "contentItemReference":
                    widget.Properties[propDef.Name] = 
                        await ResolveContentItemReference(widget.Properties[propDef.Name]);
                    break;
                case "richText":
                    widget.Properties[propDef.Name] = 
                        await SanitizeHtml(widget.Properties[propDef.Name]);
                    break;
            }
        }
        
        return widget;
    }
}
```

---

## Part 6: Execution Configuration

### appsettings.json Template (Per Workspace)

**File:** `appsettings.SITE.json`

```json
{
  "CMSConnectionString": "Server=kx13-source-db.example.com;Database=KX13_Demo;...",
  "ContentHubConnectionString": "DefaultEndpointProtocol=https;AccountName=...",
  
  "MigrationTool": {
    "SourceSiteName": "Demo",
    "TargetWorkspaceChannel": "default",
    "ExecutionMode": "FullMigration",
    "LogLevel": "Information",
    "ContinueOnMigrationFailure": false
  },
  
  "SourceInstanceApiDiscovery": {
    "Enabled": true,
    "ApiBaseUrl": "https://kx13-source.example.com/cmsapi",
    "ApiKey": "{{KX13_API_KEY}}",
    "CacheWidgetDefinitions": true
  },
  
  "ConvertClassesToContentHub": [
    {
      "SourceClassName": "BDO.Insight",
      "TargetContentTypeName": "bdo_insight",
      "SourceInstanceApiDiscoveryEnabled": true,
      "IsReusableContent": true,
      "MigrationHandler": "Kentico.Xperience.Migration.Tool.KX13.Handlers.InsightClassMapping"
    }
  ],
  
  "ReusableFieldSchemas": [
    {
      "SchemaName": "MetadataFields",
      "ApplyToContentTypes": ["bdo_insight", "news_article", "blog_post", "event"],
      "Fields": [
        "MetadataTitle", "MetadataDescription", "MetadataTeaserImage",
        "MetadataCanonical", "MetadataNoindex", "MetadataNofollow"
      ]
    },
    {
      "SchemaName": "HeroFields",
      "ApplyToContentTypes": ["bdo_insight", "news_article", "event", "home_page"],
      "Fields": [
        "HeroLayout", "HeroTitle", "HeroDescription",
        "HeroBackgroundImage", "HeroCTAButton*"
      ]
    }
  ],
  
  "EntityConfigurations": [
    {
      "SourceClassName": "BDO.Insight",
      "TargetContentTypeName": "bdo_insight",
      "FieldMigrations": [
        {
          "SourceField": "MetadataDescription",
          "TargetField": "description",
          "MigrationHandler": "Migration.Tool.Extensions.HtmlSanitizationFieldMigration"
        },
        {
          "SourceField": "HeroBackgroundImage",
          "TargetField": "heroBackgroundImage",
          "MigrationHandler": "Migration.Tool.Extensions.MediaUrlReplacementFieldMigration"
        },
        {
          "SourceField": "ItemListFeaturedItems",
          "TargetField": "featuredInsights",
          "MigrationHandler": "Migration.Tool.Extensions.PageSelectorFieldMigration"
        },
        {
          "SourceField": "ItemListFilters",
          "TargetField": "filters",
          "MigrationHandler": "Migration.Tool.Extensions.OptionsParserFieldMigration"
        }
      ],
      "ContentItemProcessor": "Migration.Tool.Extensions.InsightContentItemDirector"
    }
  ],
  
  "WidgetMigrations": [
    {
      "SourceWidgetName": "BDO.Widget.InsightCarousel",
      "TargetWidgetName": "BDO.Widget.InsightCarousel",
      "MigrationHandler": "Migration.Tool.Extensions.InsightCarouselWidgetMigration",
      "SourceInstanceApiDiscoveryEnabled": true
    },
    {
      "SourceWidgetName": "BDO.Widget.Hero",
      "TargetWidgetName": "BDO.Widget.Hero",
      "MigrationHandler": "Migration.Tool.Extensions.HeroWidgetMigration"
    },
    {
      "SourceWidgetName": "BDO.Widget.RichText",
      "TargetWidgetName": "BDO.Widget.RichText",
      "MigrationHandler": "Migration.Tool.Extensions.RichTextWidgetMigration"
    },
    {
      "SourceWidgetName": "Kentico.FormWidget",
      "TargetWidgetName": "Kentico.FormWidget",
      "MigrationHandler": "Kentico.Xperience.Migration.Tool.Common.Handlers.FormWidgetMigration"
    }
  ],
  
  "LinkedPageHandling": {
    "Strategy": "Materialize",
    "CustomTableName": "BDO.LinkedPages",
    "ProcessorClass": "Migration.Tool.Extensions.LinkedPageContentItemDirector",
    "CreateMappingLog": true,
    "SkipBrokenReferences": true
  },
  
  "MediaMigration": {
    "SourceMediaLibraryPath": "\\\\kx13-media-server\\KX13_Media",
    "ExportToTemporaryStorage": true,
    "TemporaryStoragePath": "C:\\Temp\\KX13_MediaExport",
    "BatchSize": 50,
    "CreateAssetMapping": true
  },
  
  "PostMigrationTasks": [
    {
      "Name": "ValidateAllInsights",
      "Enabled": true,
      "Query": "SELECT * FROM [View_CMS_Tree_Joined] WHERE [ClassName] = 'BDO.Insight'"
    },
    {
      "Name": "GenerateAssetMappingReport",
      "Enabled": true,
      "OutputPath": "migration-reports/asset-mapping.json"
    },
    {
      "Name": "ValidateLinkedPages",
      "Enabled": true,
      "CheckUnresolvedReferences": true
    }
  ]
}
```

### Code Extensions Structure

**Project:** `Migration.Tool.Extensions`

```
Migration.Tool.Extensions/
├── ClassMappings/
│   ├── InsightClassMapping.cs
│   ├── NewsArticleClassMapping.cs
│   ├── BlogPostClassMapping.cs
│   └── ...
├── FieldMigrations/
│   ├── HtmlSanitizationFieldMigration.cs
│   ├── MediaUrlReplacementFieldMigration.cs
│   ├── PageSelectorFieldMigration.cs
│   ├── OptionsParserFieldMigration.cs
│   └── ...
├── WidgetMigrations/
│   ├── InsightCarouselWidgetMigration.cs
│   ├── HeroWidgetMigration.cs
│   ├── RichTextWidgetMigration.cs
│   └── ...
├── ContentItemDirectors/
│   ├── InsightContentItemDirector.cs
│   ├── LinkedPageContentItemDirector.cs
│   └── ...
├── Models/
│   ├── NodeToContentItemMapping.cs
│   ├── MediaGuidMapping.cs
│   └── ...
└── Extensions.cs (DI registration)
```

**Extensions.cs (Dependency Injection):**
```csharp
public static class MigrationExtensions
{
    public static IServiceCollection AddCustomMigrationHandlers(
        this IServiceCollection services)
    {
        // Class mappings
        services.AddScoped<IClassMapping, InsightClassMapping>();
        services.AddScoped<IClassMapping, NewsArticleClassMapping>();
        
        // Field migrations
        services.AddScoped<IFieldMigration, HtmlSanitizationFieldMigration>();
        services.AddScoped<IFieldMigration, MediaUrlReplacementFieldMigration>();
        services.AddScoped<IFieldMigration, PageSelectorFieldMigration>();
        
        // Widget migrations
        services.AddScoped<IWidgetMigration, InsightCarouselWidgetMigration>();
        services.AddScoped<IWidgetMigration, HeroWidgetMigration>();
        
        // Content item directors
        services.AddScoped<ContentItemDirectorBase, InsightContentItemDirector>();
        services.AddScoped<ContentItemDirectorBase, LinkedPageContentItemDirector>();
        
        return services;
    }
}
```

---

## Part 7: Execution Checklist

### Pre-Migration

- [ ] 8 XbyK workspaces created
- [ ] Content Hub channels configured
- [ ] Source Instance API endpoints deployed & tested
- [ ] KX13 database backup created
- [ ] Media library inventory prepared
- [ ] Custom form controls documented
- [ ] appsettings.json files created (8 copies, one per site)
- [ ] IClassMapping implementations reviewed
- [ ] IFieldMigration implementations unit tested
- [ ] IWidgetMigration implementations unit tested
- [ ] Linked page mapping strategy documented
- [ ] Media URL transformation patterns validated

### Dry-Run (Demo Site)

- [ ] Run: `dotnet Migration.Tool.CLI run --settings appsettings.demo.json`
- [ ] Validate Insight items created in Content Hub
- [ ] Spot-check metadata fields: title, description, hero image
- [ ] Verify widget properties mapped correctly
- [ ] Check linked page references resolved
- [ ] Test page rendering (Hero widget, Carousel, etc.)
- [ ] Review migration logs for errors/warnings
- [ ] Spot-check media assets imported
- [ ] Validate forms submitted successfully
- [ ] Document blockers; refine handlers

### Bulk Migration (Run 1-8)

- [ ] Run 1: Demo
- [ ] Run 2: E2E_Performance
- [ ] Run 3: GWTBDOIndiaTeam
- [ ] Run 4: GWTExport
- [ ] Run 5: GWT_TST
- [ ] Run 6: Integrations
- [ ] Run 7: Www.bdowow.com
- [ ] Run 8: BDOWOW

**Per Run:**
- [ ] Monitor migration progress
- [ ] Check error logs
- [ ] Record item counts (Insights, News, etc.)
- [ ] Spot-check 5-10 pages per site
- [ ] Verify page builder sections load
- [ ] Test linked page rendering

### Post-Migration Validation

- [ ] All Insight items present (count KX13 vs XbyK)
- [ ] All NewsArticle items present
- [ ] Media asset counts match
- [ ] Linked page references valid (no broken links)
- [ ] Hero images display correctly
- [ ] Widget carousels query Insight items successfully
- [ ] Form submissions send notifications
- [ ] SEO metadata (OG tags, robots) present
- [ ] URL slugs correct
- [ ] Multilingual content (cultures) preserved

### Sign-Off

- [ ] Content team: Sample content review
- [ ] QA team: Functional testing passed
- [ ] DevOps: Performance testing passed
- [ ] Security: No sensitive data exposed
- [ ] Product owner: Approval to proceed to launch

---

## Part 8: Troubleshooting & Common Issues

### Issue: Widget Properties Not Mapping

**Symptoms:**
- Widget appears in page but properties empty
- InsightCarousel shows no featured items

**Root Cause:**
- Custom form control type not recognized
- Property name mismatch
- Source Instance API unreachable

**Resolution:**
1. Verify Source Instance API running: `curl -X GET https://kx13.api/tools/widgets`
2. Check IWidgetMigration implementation: log property names
3. If API unavailable, fallback to manual property definition in XbyK
4. Re-run migration with updated handler

### Issue: Media URLs Not Resolved

**Symptoms:**
- Hero images show 404 errors
- Background image not displaying

**Root Cause:**
- Media GUID mapping missing
- Asset not imported to Content Hub
- URL pattern mismatch in regex

**Resolution:**
1. Check media migration log: `migration-reports/asset-mapping.json`
2. Verify assets exist in XbyK Content Hub
3. Review MediaUrlReplacementFieldMigration regex pattern
4. Re-import missing assets manually
5. Re-run field migration

### Issue: Linked Pages Not Resolved

**Symptoms:**
- KeyContacts widget shows empty
- ItemListFeaturedItems array empty

**Root Cause:**
- Node ID mapping not found
- Target content item not migrated yet
- Culture mismatch in selector query

**Resolution:**
1. Check linked page mapping log
2. Verify all referenced page types migrated
3. Review IContentItemDirectorBase logic for culture handling
4. If one-to-many relationships, ensure array fields exist in schema
5. Re-run with updated handler

### Issue: Form Widget Not Rendering

**Symptoms:**
- Kentico.FormWidget shows error
- Form submission fails

**Root Cause:**
- Form not migrated
- Form identifier incorrect
- Form schema mismatch (fields added/removed)

**Resolution:**
1. Migrate forms separately: `dotnet Migration.Tool.CLI run --settings appsettings.forms.json`
2. Verify form GUID in XbyK
3. Update IWidgetMigration: map form ID to GUID
4. Re-import widget configuration

### Issue: HTML Content Corrupted

**Symptoms:**
- Rich text shows markup characters
- Scripts/unsafe content not removed

**Root Cause:**
- HtmlSanitizationFieldMigration not applied
- HTML encoding issues
- Line break handling

**Resolution:**
1. Review HtmlSanitizationFieldMigration in FieldMigrations config
2. Verify HTML Agility Pack or similar sanitization library installed
3. Check for encoding issues: UTF-8 vs other
4. Test on small subset first; refine regex patterns
5. Re-run with corrected handler

---

## Part 9: Rollback & Recovery

### Pre-Migration Backups

1. **KX13 Database Backup** (Read-Only)
   - Location: `\\backup-server\KX13_Full_Backup_2026-08-20.bak`
   - Keep until migration complete and verified

2. **XbyK Database Backup** (Per Workspace, Post-Migration)
   - Location: `\\backup-server\XbyK_[SITE]_PostMigration_2026-08-20.bak`
   - Allows rollback to pre-migration state

### Rollback Procedure

**If Critical Issues Found:**

1. Stop ongoing migration runs
2. Restore XbyK database from backup
3. Investigate root cause:
   - Review migration logs
   - Refine IClassMapping/IFieldMigration code
   - Add validation rules
4. Re-run dry-run on Demo site
5. Once verified, resume bulk migration

**Rollback Command:**
```powershell
# Stop running migrations
Stop-Process -Name "Migration.Tool.CLI" -Force

# Restore XbyK database
Restore-SqlDatabase -Database "XbyK_[SITE]" -BackupFile "\\backup-server\XbyK_[SITE]_PreMigration.bak"

# Verify restore
dotnet Migration.Tool.CLI verify --workspace "[SITE]" --checkItemCount
```

---

## Appendix: File Structures

### Node-to-ContentItem Mapping Format

**Output:** `migration-logs/node-to-item-mapping.json`

```json
{
  "demo": [
    {
      "sourceNodeId": 691,
      "sourceNodeGuid": "653aa32f-7b03-4d45-90f8-099fed112a5a",
      "sourceClassName": "BDO.Insight",
      "targetContentType": "bdo_insight",
      "targetItemGuid": "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
      "targetItemId": 12345,
      "cultures": ["en-GB", "he-IL", "lt-LT"],
      "status": "migrated"
    }
  ]
}
```

### Asset Mapping Format

**Output:** `migration-logs/asset-mapping.json`

```json
{
  "assets": [
    {
      "sourceMediaId": 1001,
      "sourceMediaGuid": "b2c3d4e5-f678-9012-abcd-ef1234567890",
      "sourceMediaPath": "/getmedia/b2c3d4e5-f678-9012-abcd-ef1234567890/hero-image.jpg",
      "targetAssetGuid": "c3d4e5f6-7890-1234-abcd-ef1234567890",
      "targetAssetPath": "/api/assets/c3d4e5f6-7890-1234-abcd-ef1234567890",
      "fileName": "hero-image.jpg",
      "fileSize": 2048576,
      "contentType": "image/jpeg",
      "status": "imported"
    }
  ]
}
```

---

**Document Version:** 1.0  
**Last Updated:** 2026-08-20  
**Status:** Ready for Implementation
