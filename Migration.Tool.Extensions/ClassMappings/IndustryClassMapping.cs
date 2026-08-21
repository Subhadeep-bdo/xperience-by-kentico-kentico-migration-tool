using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.Industry (in place, stays a webpage content type; inherits BDO.Metadata) to compose its
/// metadata fields from the shared BDO.MetadataFields schema. All other own fields keep their KX13 names
/// and are migrated automatically.
/// </summary>
public static class IndustryClassMapping
{
    private const string TargetClassName = "BDO.Industry";
    private const string SourceClassName = "BDO.Industry";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_Industry";
            target.ClassDisplayName = "Industry";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("IndustryID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddIndustryMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
