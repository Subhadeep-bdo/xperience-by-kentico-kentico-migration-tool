using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Converts BDO.SectionInsightsPage into a reusable Content hub item (required so InsightChildLinkDirector's
/// LinkChildren call can attach BDO.Insight children - LinkChildren requires the parent type to also be
/// reusable). Composes metadata fields from the shared BDO.MetadataFields schema (verified same fieldGuids
/// as BDO.Metadata, inherited via BDO.ContentSectionPage). All other own fields keep their KX13 names and
/// are migrated automatically.
///
/// Prerequisite: "BDO.SectionInsightsPage" must be listed in Settings.ConvertClassesToContentHub in
/// appsettings.json.
/// </summary>
public static class SectionInsightsPageClassMapping
{
    private const string TargetClassName = "BDO.SectionInsightsPage";
    private const string SourceClassName = "BDO.SectionInsightsPage";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_SectionInsightsPage";
            target.ClassDisplayName = "Section Insights Page";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.REUSABLE;
            target.ClassWebPageHasUrl = false;
        });

        m.BuildField("SectionInsightsPageID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddSectionInsightsPageMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
