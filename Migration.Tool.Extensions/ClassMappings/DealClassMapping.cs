using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.Deal (in place, stays a webpage content type; inherits BDO.Metadata) to compose its
/// metadata fields from the shared BDO.MetadataFields schema. All other own fields keep their KX13 names
/// and are migrated automatically.
/// </summary>
public static class DealClassMapping
{
    private const string TargetClassName = "BDO.Deal";
    private const string SourceClassName = "BDO.Deal";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_Deal";
            target.ClassDisplayName = "Deal";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("DealID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddDealMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
