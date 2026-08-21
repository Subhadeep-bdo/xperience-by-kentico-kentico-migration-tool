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

        sb.BuildField("title").WithFactory(() => new FormFieldInfo
        {
            Name = "title",
            Caption = "Title",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|title"),
            DataType = FieldDataType.Text,
            Size = 200,
            AllowEmpty = false,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("description").WithFactory(() => new FormFieldInfo
        {
            Name = "description",
            Caption = "Description",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|description"),
            DataType = FieldDataType.RichTextHTML,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminRichTextEditorComponent }
        });

        // Source is a Text field with the MediaSelectionControl; converted to a content item asset reference
        // (not a legacy Media Library file, per appsettings MigrateMediaToMediaLibrary: false) by the
        // OptInFeatures.CustomMigration.FieldMigrations rule configured in appsettings.json.
        sb.BuildField("teaserImage").WithFactory(() => new FormFieldInfo
        {
            Name = "teaserImage",
            Caption = "Teaser image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|teaserImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("teaserImageAltText").WithFactory(() => new FormFieldInfo
        {
            Name = "teaserImageAltText",
            Caption = "Teaser image alt text",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|teaserImageAltText"),
            DataType = FieldDataType.Text,
            Size = 200,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("canonicalUrl").WithFactory(() => new FormFieldInfo
        {
            Name = "canonicalUrl",
            Caption = "Canonical link",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|canonicalUrl"),
            DataType = FieldDataType.Text,
            Size = 2000,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("ogTitle").WithFactory(() => new FormFieldInfo
        {
            Name = "ogTitle",
            Caption = "OG metadata title",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|ogTitle"),
            DataType = FieldDataType.Text,
            Size = 60,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextInputComponent }
        });

        sb.BuildField("ogDescription").WithFactory(() => new FormFieldInfo
        {
            Name = "ogDescription",
            Caption = "OG metadata description",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|ogDescription"),
            DataType = FieldDataType.Text,
            Size = 500,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminTextAreaComponent }
        });

        sb.BuildField("ogImage").WithFactory(() => new FormFieldInfo
        {
            Name = "ogImage",
            Caption = "OG metadata image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|ogImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("ogTwitterImageSizeCheckbox").WithFactory(() => new FormFieldInfo
        {
            Name = "ogTwitterImageSizeCheckbox",
            Caption = "Use small image for Twitter (1:1)",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|ogTwitterImageSizeCheckbox"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("ogTwitterImage").WithFactory(() => new FormFieldInfo
        {
            Name = "ogTwitterImage",
            Caption = "Twitter OG metadata image",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|ogTwitterImage"),
            DataType = FieldDataType.ContentItemReference,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminAssetSelectorComponent }
        });

        sb.BuildField("metaNofollow").WithFactory(() => new FormFieldInfo
        {
            Name = "metaNofollow",
            Caption = "Nofollow",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|metaNofollow"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("metaNoindex").WithFactory(() => new FormFieldInfo
        {
            Name = "metaNoindex",
            Caption = "Noindex",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|metaNoindex"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        sb.BuildField("includeInSitemap").WithFactory(() => new FormFieldInfo
        {
            Name = "includeInSitemap",
            Caption = "Include page in the sitemap",
            Guid = GuidHelper.CreateFieldGuid("bdo.metadatafields|includeInSitemap"),
            DataType = FieldDataType.Boolean,
            AllowEmpty = true,
            DefaultValue = "true",
            Settings = { ["controlname"] = FormComponents.AdminCheckBoxComponent }
        });

        return sb;
    }

    /// <summary>
    /// Maps the 13 BDO.Metadata-derived fields of <paramref name="sourceClassName"/> onto the
    /// BDO.MetadataFields schema fields. Call after <c>m.UseReusableSchema(SchemaName)</c>.
    /// </summary>
    public static void MapCommonFields(MultiClassMapping m, string sourceClassName)
    {
        m.UseReusableSchema(SchemaName);

        m.BuildField("title").SetFrom(sourceClassName, "MetadataTitle");
        m.BuildField("description").SetFrom(sourceClassName, "MetadataDescription");
        m.BuildField("teaserImage").SetFrom(sourceClassName, "MetadataTeaserImage");
        m.BuildField("teaserImageAltText").SetFrom(sourceClassName, "MetadataTeaserImageAltText");
        m.BuildField("canonicalUrl").SetFrom(sourceClassName, "MetadataCanonical");
        m.BuildField("ogTitle").SetFrom(sourceClassName, "MetadataOGTitle");
        m.BuildField("ogDescription").SetFrom(sourceClassName, "MetadataOGDescription");
        m.BuildField("ogImage").SetFrom(sourceClassName, "MetadataOGImage");
        m.BuildField("ogTwitterImageSizeCheckbox").SetFrom(sourceClassName, "MetadataOGTwitterImageSizeCheckbox");
        m.BuildField("ogTwitterImage").SetFrom(sourceClassName, "MetadataOGTwitterImage");
        m.BuildField("metaNofollow").SetFrom(sourceClassName, "MetadataNofollow");
        m.BuildField("metaNoindex").SetFrom(sourceClassName, "MetadataNoindex");
        m.BuildField("includeInSitemap").SetFrom(sourceClassName, "IncludeInSitemap");
    }

    public static IServiceCollection AddMetadataFieldsSchema(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IReusableSchemaBuilder>(Build());
        return serviceCollection;
    }
}
