using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.BlogPost (in place, stays a webpage content type) to compose its BDO.Metadata-derived fields
/// from the shared BDO.MetadataFields schema. All other own fields keep their KX13 names and are migrated
/// automatically.
/// </summary>
public static class BlogPostClassMapping
{
    private const string TargetClassName = "BDO.BlogPost";
    private const string SourceClassName = "BDO.BlogPost";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_BlogPost";
            target.ClassDisplayName = "Blog Post";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("BlogPostID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddBlogPostMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
