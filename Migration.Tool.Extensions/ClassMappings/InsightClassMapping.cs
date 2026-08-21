using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Converts the BDO.Insight page type (in place, same class name) into a reusable Content hub item and
/// composes it from the shared BDO.MetadataFields schema.
///
/// Field names verified against audit-results/page-types.json (real KX13 audit) - NOT the fictional
/// Hero/ItemList fields described in the earlier migration-detail.md draft, which do not exist on BDO.Insight.
///
/// Fields with unchanged source/target names (ShowTitle, Content, ShowDescription, ShowSidebar, ShowCallToAction,
/// CallToActionDescription, CallToActionButtonText, CallToActionButtonUrl, CallToActionPosition, ShowPrintButton,
/// DownloadButtonAttachment, ShowSocialMediaButtons, UseNarrowLayout, ShowAuthorsAtTheTop, Image, ImageAltText,
/// InsightAttachment, DownloadButtonTitle, DownloadButtonText, UpdatedOn) are migrated automatically by the tool's
/// default field mapping and do not require explicit mapping here.
///
/// NOT covered by this mapping (separate extension points, see migration plan follow-up items):
///   - MetadataBusinessIssues, MetadataBusinessLines, MetadataServiceAreas, MetadataServices,
///     MetadataIndustryCategories, MetadataIndustries, MetadataSpecialties*, MetadataOfficeLocation
///     - MultiSelector fields backed by BDO.LinkedPages node relationships; handle via /migrate-content-items
///       (ContentItemDirectorBase) or /migrate-content-fields (IFieldMigration), not plain class mapping.
/// </summary>
public static class InsightClassMapping
{
    private const string TargetClassName = "BDO.Insight";
    private const string SourceClassName = "BDO.Insight";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_Insight";
            target.ClassDisplayName = "Insight";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.REUSABLE;
            target.ClassWebPageHasUrl = false;
        });

        m.BuildField("InsightID").AsPrimaryKey();

        // Assign the shared metadata schema and map its 13 fields (see MetadataFieldsSchema.cs).
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddInsightMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
