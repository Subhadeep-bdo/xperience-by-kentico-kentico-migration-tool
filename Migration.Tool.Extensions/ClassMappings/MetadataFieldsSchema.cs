using CMS.DataEngine;
using CMS.FormEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;
using Migration.Tool.Common.Helpers;
using Migration.Tool.KXP.Api.Auxiliary;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Reusable field schema for the common SEO/metadata fields physically defined on the KX13 "BDO.Metadata" base
/// class (same fieldGuids duplicated into BDO.Insight, BDO.NewsArticle, BDO.BlogPost, BDO.HomePage, BDO.Event
/// (via BDO.EventBase), BDO.ServiceArea, BDO.Deal, BDO.Industry, BDO.InsightCategory - verified against
/// audit-results/page-types.json).
/// </summary>
public static class MetadataFieldsSchema
{
    public const string SchemaName = "BDO.MetadataFields";

    public static ReusableSchemaBuilder Build()
    {
        var sb = new ReusableSchemaBuilder(SchemaName, "Metadata Fields",
            "Shared SEO/metadata fields (title, description, teaser image, canonical link, OG tags, SEO flags)");

        sb.BuildField("bdo_title").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_title",
            Caption = "Title",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_title"),
            DataType = FieldDataType.Text,
            Size = 200,
            AllowEmpty = false,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("bdo_description").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_description",
            Caption = "Description",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_description"),
            DataType = FieldDataType.RichTextHTML,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminRichTextEditorComponent }
        });

        // Source is a Text field with the MediaSelectionControl; converted to a content item asset reference
        // (not a legacy Media Library file, per appsettings MigrateMediaToMediaLibrary: false) by the
        // OptInFeatures.CustomMigration.FieldMigrations rule configured in appsettings.json.
        sb.BuildField("bdo_teaserImage").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_teaserImage",
            Caption = "Teaser image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_teaserImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("bdo_teaserImageAltText").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_teaserImageAltText",
            Caption = "Teaser image alt text",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_teaserImageAltText"),
            DataType = FieldDataType.Text,
            Size = 200,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("bdo_canonicalUrl").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_canonicalUrl",
            Caption = "Canonical link",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_canonicalUrl"),
            DataType = FieldDataType.Text,
            Size = 2000,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("bdo_ogTitle").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_ogTitle",
            Caption = "OG metadata title",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_ogTitle"),
            DataType = FieldDataType.Text,
            Size = 60,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("bdo_ogDescription").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_ogDescription",
            Caption = "OG metadata description",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_ogDescription"),
            DataType = FieldDataType.Text,
            Size = 500,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextAreaComponent }
        });

        sb.BuildField("bdo_ogImage").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_ogImage",
            Caption = "OG metadata image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_ogImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("bdo_ogTwitterImageSizeCheckbox").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_ogTwitterImageSizeCheckbox",
            Caption = "Use small image for Twitter (1:1)",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_ogTwitterImageSizeCheckbox"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("bdo_ogTwitterImage").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_ogTwitterImage",
            Caption = "Twitter OG metadata image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_ogTwitterImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("bdo_metaNofollow").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_metaNofollow",
            Caption = "Nofollow",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_metaNofollow"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("bdo_metaNoindex").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_metaNoindex",
            Caption = "Noindex",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_metaNoindex"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("bdo_includeInSitemap").WithFactory(() => new FormFieldInfo
        {
            Name = "bdo_includeInSitemap",
            Caption = "Include page in the sitemap",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|bdo_includeInSitemap"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            DefaultValue = "true",
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        return sb;
    }

    /// <summary>
    /// Maps the 13 BDO.Metadata-derived fields of <paramref name="sourceClassName"/> onto the
    /// BDO.MetadataFields schema fields (with bdo_ prefix to avoid conflicts with CMS.ContentItemCommonData).
    /// Call after <c>m.UseReusableSchema(SchemaName)</c>.
    /// </summary>
    public static void MapCommonFields(MultiClassMapping m, string sourceClassName)
    {
        m.UseReusableSchema(SchemaName);

        m.BuildField("bdo_title").SetFrom(sourceClassName, "MetadataTitle");
        m.BuildField("bdo_description").SetFrom(sourceClassName, "MetadataDescription");
        m.BuildField("bdo_teaserImage").SetFrom(sourceClassName, "MetadataTeaserImage");
        m.BuildField("bdo_teaserImageAltText").SetFrom(sourceClassName, "MetadataTeaserImageAltText");
        m.BuildField("bdo_canonicalUrl").SetFrom(sourceClassName, "MetadataCanonical");
        m.BuildField("bdo_ogTitle").SetFrom(sourceClassName, "MetadataOGTitle");
        m.BuildField("bdo_ogDescription").SetFrom(sourceClassName, "MetadataOGDescription");
        m.BuildField("bdo_ogImage").SetFrom(sourceClassName, "MetadataOGImage");
        m.BuildField("bdo_ogTwitterImageSizeCheckbox").SetFrom(sourceClassName, "MetadataOGTwitterImageSizeCheckbox");
        m.BuildField("bdo_ogTwitterImage").SetFrom(sourceClassName, "MetadataOGTwitterImage");
        m.BuildField("bdo_metaNofollow").SetFrom(sourceClassName, "MetadataNofollow");
        m.BuildField("bdo_metaNoindex").SetFrom(sourceClassName, "MetadataNoindex");
        m.BuildField("bdo_includeInSitemap").SetFrom(sourceClassName, "IncludeInSitemap");
    }

    public static IServiceCollection AddMetadataFieldsSchema(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IReusableSchemaBuilder>(Build());
        return serviceCollection;
    }
}
