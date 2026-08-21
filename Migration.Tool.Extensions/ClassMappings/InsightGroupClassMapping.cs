using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Converts BDO.InsightGroup into a reusable Content hub item (required so InsightChildLinkDirector's
/// LinkChildren call can attach BDO.Insight children - LinkChildren requires the parent type to also be
/// reusable). Composes metadata fields from the shared BDO.MetadataFields schema (verified same fieldGuids
/// as BDO.Metadata). All other own fields keep their KX13 names and are migrated automatically.
///
/// Prerequisite: "BDO.InsightGroup" must be listed in Settings.ConvertClassesToContentHub in appsettings.json.
/// </summary>
public static class InsightGroupClassMapping
{
    private const string TargetClassName = "BDO.InsightGroup";
    private const string SourceClassName = "BDO.InsightGroup";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_InsightGroup";
            target.ClassDisplayName = "Insight Group";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.REUSABLE;
            target.ClassWebPageHasUrl = false;
        });

        m.BuildField("InsightGroupID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddInsightGroupMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
