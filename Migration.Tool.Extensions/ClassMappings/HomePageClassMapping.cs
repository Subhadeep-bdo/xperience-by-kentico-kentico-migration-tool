using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.HomePage (in place, stays a webpage content type; inherits BDO.Metadata) to compose its
/// metadata fields from the shared BDO.MetadataFields schema. All other own fields keep their KX13 names
/// and are migrated automatically.
/// </summary>
public static class HomePageClassMapping
{
    private const string TargetClassName = "BDO.HomePage";
    private const string SourceClassName = "BDO.HomePage";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_HomePage";
            target.ClassDisplayName = "Home Page";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("HomePageID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddHomePageMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
