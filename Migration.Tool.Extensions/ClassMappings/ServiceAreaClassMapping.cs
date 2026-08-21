using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.ServiceArea (in place, stays a webpage content type; inherits BDO.Metadata) to compose its
/// metadata fields from the shared BDO.MetadataFields schema. All other own fields keep their KX13 names
/// and are migrated automatically.
/// </summary>
public static class ServiceAreaClassMapping
{
    private const string TargetClassName = "BDO.ServiceArea";
    private const string SourceClassName = "BDO.ServiceArea";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_ServiceArea";
            target.ClassDisplayName = "Service Area";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("ServiceAreaID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddServiceAreaMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
