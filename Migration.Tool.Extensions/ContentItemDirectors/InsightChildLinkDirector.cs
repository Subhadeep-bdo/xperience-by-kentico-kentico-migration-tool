using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Source.Mappers.ContentItemMapperDirectives;

namespace Migration.Tool.Extensions.ContentItemDirectors;

/// <summary>
/// BDO.Insight becomes a reusable Content hub item (see InsightClassMapping.cs) and therefore leaves the web
/// page tree - its former parent container would otherwise lose the ability to list its insights. This
/// director links the direct BDO.Insight children of the three real container/category types found in the
/// tree (audit-results/content-model-report.md) as content item references instead:
///   - BDO.SectionInsightsPage (classId 5543) - e.g. /Insights, /Section-Insights
///   - BDO.InsightCategory (classId 5526)     - e.g. /Insights/IT-Compliance
///   - BDO.InsightGroup (classId 5524)         - e.g. /Insights/מיסים/מבזקי-מס
///
/// Prerequisite: "BDO.Insight" must remain listed in Settings.ConvertClassesToContentHub in appsettings.json -
/// LinkChildren silently fails to create the reference if the child type isn't in that list (already satisfied).
/// </summary>
public class InsightChildLinkDirector : ContentItemDirectorBase
{
    private const int InsightClassId = 5512;
    private const int SectionInsightsPageClassId = 5543;
    private const int InsightCategoryClassId = 5526;
    private const int InsightGroupClassId = 5524;

    public override void Direct(ContentItemSource source, IContentItemActionProvider options)
    {
        int? sourceClassId = source.SourceNode?.NodeClassID;
        if (sourceClassId is SectionInsightsPageClassId or InsightCategoryClassId or InsightGroupClassId
            && source.ChildNodes is { } childNodes)
        {
            options.LinkChildren("insights", childNodes.Where(c => c.NodeClassID == InsightClassId));
        }

        // Unhandled sources: no action = default migration behavior.
    }
}

public static class InsightChildLinkDirectorExtensions
{
    public static IServiceCollection AddInsightChildLinkDirector(this IServiceCollection services)
    {
        // Prerequisites: --pages included in the CLI execution; "BDO.Insight" present in
        // Settings.ConvertClassesToContentHub (appsettings.json).
        services.AddTransient<ContentItemDirectorBase, InsightChildLinkDirector>();
        return services;
    }
}
