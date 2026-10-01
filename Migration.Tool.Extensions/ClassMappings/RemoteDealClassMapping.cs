using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

public static class RemoteDealClassMapping
{
    private const string SourceClassName = "BDO.RemoteDeal";

    public static IServiceCollection AddRemoteDealMapping(this IServiceCollection services)
    {
        var mapping = new MultiClassMapping(SourceClassName, target =>
        {
            target.ClassName = SourceClassName;
            target.ClassTableName = "BDO_RemoteDeal";
            target.ClassDisplayName = "Remote Deal";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        mapping.BuildField("RemoteDealID").AsPrimaryKey();

        // Reference/asset fields — source stores raw codenames/paths that are not valid target references
        MapEmptyReference(mapping, "Industry");
        MapEmptyReference(mapping, "SubIndustry");
        MapEmptyReference(mapping, "DealType");
        MapEmptyReference(mapping, "MetadataTeaserImage");

        // Remaining scalar fields (DateField, DealCountry, Original*, ForceUpdateOnNextSync,
        // MetadataTitle, MetadataDescription, MetadataTeaserImageAltText, IncludeInSitemap) pass through by same name.

        services.AddSingleton<IClassMapping>(mapping);

        return services;
    }

    private static void MapEmptyReference(MultiClassMapping mapping, string targetFieldName) =>
        mapping.BuildField(targetFieldName).ConvertFrom(SourceClassName, "RemoteDealID", false, static (_, _) => "[]");
}
