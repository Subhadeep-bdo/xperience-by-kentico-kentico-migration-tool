using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Remodels BDO.NewsArticle (in place, stays a webpage content type) to compose its BDO.Metadata-derived
/// fields from the shared BDO.MetadataFields schema. All other fields (ShowTitle, Content, ShowDescription,
/// UpdatedOn, ShowSidebar, ShowPrintButton, DownloadButtonAttachment, ShowSocialMediaButtons, ShowCallToAction,
/// CallToAction*, Image, ImageAltText, ContentType, Metadata*[Business/Service/Industry - MultiSelector
/// relationship fields], PeopleSort, RelevantContactPerson, RelatedExternalPeople) keep their KX13 names and
/// are migrated automatically.
/// </summary>
public static class NewsArticleClassMapping
{
    private const string TargetClassName = "BDO.NewsArticle";
    private const string SourceClassName = "BDO.NewsArticle";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_NewsArticle";
            target.ClassDisplayName = "News Article";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.WEBSITE;
        });

        m.BuildField("NewsArticleID").AsPrimaryKey();
        MetadataFieldsSchema.MapCommonFields(m, SourceClassName);

        return m;
    }

    public static IServiceCollection AddNewsArticleMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
