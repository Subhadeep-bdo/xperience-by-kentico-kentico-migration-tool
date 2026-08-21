using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Source.Mappers.ContentItemMapperDirectives;

namespace Migration.Tool.Extensions.ContentItemDirectors;

/// <summary>
/// Drops utility/system pages that should not become real content items. Paths verified against
/// audit-results/content-model-report.md: /Error-Pages (BDO.StatusCode 401/403/404/500),
/// /Status-Code-Pages (BDO.StatusCode 404/500), /Reusable-Content-Tab (shared reusable widget content
/// source folder, not meant to be visited directly). Without this, these pages would migrate using their
/// source class's default mapping (e.g., a folder or status-code page mapped like ordinary content).
/// </summary>
public class UtilityPageDirector : ContentItemDirectorBase
{
    private static readonly string[] UtilityPathPrefixes =
    [
        "/Error-Pages",
        "/Status-Code-Pages",
        "/Reusable-Content-Tab"
    ];

    public override void Direct(ContentItemSource source, IContentItemActionProvider options)
    {
        string? path = source.SourceNode?.NodeAliasPath;
        if (path is not null && UtilityPathPrefixes.Any(prefix => path.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)))
        {
            options.Drop();
        }

        // Unhandled pages: no action = default migration behavior. Do NOT call base.Direct() (abstract).
    }
}

public static class UtilityPageDirectorExtensions
{
    public static IServiceCollection AddUtilityPageDirector(this IServiceCollection services)
    {
        // Prerequisite: --pages must be included in the CLI execution.
        services.AddTransient<ContentItemDirectorBase, UtilityPageDirector>();
        return services;
    }
}
