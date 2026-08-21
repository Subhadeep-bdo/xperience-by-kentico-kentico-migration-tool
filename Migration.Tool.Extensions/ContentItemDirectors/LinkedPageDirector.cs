using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Source.Mappers.ContentItemMapperDirectives;

namespace Migration.Tool.Extensions.ContentItemDirectors;

/// <summary>
/// Drops all KX13 linked pages instead of the default Materialize behavior, to avoid silently duplicating
/// content. Verified against audit-results/content-model-report.md - 6 real linked pages exist (Integrations
/// site only; all other sites report 0):
///   - /Blogs/BDO-Healthcare/Contributors/Person1            (BDO.Person, original: /Our-People/Person1)
///   - /Blogs/RK-Blog/Contributors/Bio-page                  (BDO.Person, original: /Our-People/Bio-page)
///   - /Blogs/Tech-Media-Watch-Blog/Contributors/Juanita-House (BDO.Person, original: /Our-People/Juanita-House)
///   - /Deals/MV-Deal-3-(2)                                  (BDO.Deal, original: /Deals/MV-Deal-3)
///   - /Insights/.../Julegave-fra-arbeidsgiver-skattefritt-eller-skatte (BDO.Insight, original under /Insights/IT-Compliance/)
///   - /Navigation/Services/Insight-1                        (BDO.NavigationSecondLevelItem, original: /Navigation/Insights/Insight-1)
///
/// TODO: If the blog contributor / deal / insight duplication should instead resolve to a reference to the
/// original content item, switch the relevant case to
/// <c>options.StoreReferenceInAncestor(-1, "FieldName")</c> once the ancestor content type has (or will have)
/// a matching content item reference field.
/// </summary>
public class LinkedPageDirector : ContentItemDirectorBase
{
    // No content-item-level customization needed here - only linked page handling below.
    public override void Direct(ContentItemSource source, IContentItemActionProvider options)
    {
    }

    public override void DirectLinkedNode(LinkedPageSource source, ILinkedPageActionProvider options)
        => options.Drop();
}

public static class LinkedPageDirectorExtensions
{
    public static IServiceCollection AddLinkedPageDirector(this IServiceCollection services)
    {
        // Prerequisite: --pages must be included in the CLI execution.
        services.AddTransient<ContentItemDirectorBase, LinkedPageDirector>();
        return services;
    }
}
