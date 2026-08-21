using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.Event (in place, stays a webpage content type; inherits BDO.Metadata via BDO.EventBase)
/// to compose its metadata fields from the shared BDO.MetadataFields schema. All other own fields keep
/// their KX13 names and are migrated automatically.
/// </summary>
public static class EventClassMapping
{
    private const string TargetClassName = "BDO.Event";
    private const string SourceClassName = "BDO.Event";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_Event";
            target.ClassDisplayName = "Event";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("EventID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddEventMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
