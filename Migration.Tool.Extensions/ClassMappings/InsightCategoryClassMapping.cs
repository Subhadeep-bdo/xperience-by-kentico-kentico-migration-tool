using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Converts BDO.InsightCategory into a reusable Content hub item (required so InsightChildLinkDirector's
/// LinkChildren call can attach BDO.Insight children - LinkChildren requires the parent type to also be
/// reusable). Composes metadata fields from the shared BDO.MetadataFields schema. All other own fields keep
/// their KX13 names and are migrated automatically.
///
/// Prerequisite: "BDO.InsightCategory" must be listed in Settings.ConvertClassesToContentHub in appsettings.json.
/// </summary>
public static class InsightCategoryClassMapping
{
    private const string TargetClassName = "BDO.InsightCategory";
    private const string SourceClassName = "BDO.InsightCategory";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_InsightCategory";
            target.ClassDisplayName = "Insight Category";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.REUSABLE;
            target.ClassWebPageHasUrl = false;
        });

        m.BuildField("InsightCategoryID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddInsightCategoryMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
