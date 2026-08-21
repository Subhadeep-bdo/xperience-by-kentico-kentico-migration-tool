using System.Text.RegularExpressions;
using System.Xml.Linq;
using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common;
using Migration.Tool.KXP.Api.Auxiliary;
using Migration.Tool.KXP.Api.Services.CmsClass;

namespace Migration.Tool.Extensions.FieldMigrations;

/// <summary>
/// Sanitizes KX13 rich text (HtmlAreaControl) field values during migration - strips &lt;script&gt; tags,
/// inline event-handler attributes (onclick, onerror, ...), and javascript: URLs. Applies to every class using
/// the HtmlAreaControl form control (e.g., MetadataDescription, Content, SharingInstructions across all BDO
/// content page types - verified via audit-results/page-types.json).
///
/// Also performs the built-in field definition change (longtext + HtmlAreaControl -&gt; richtexthtml +
/// RichTextEditor) since a lower Rank than the built-in default means this migration takes over both
/// MigrateFieldDefinition and MigrateValue for matching fields.
/// </summary>
public class HtmlSanitizationFieldMigration : IFieldMigration
{
    private const string SourceDataType_LongText = "longtext";
    private const string SourceFormControl_HtmlArea = "HtmlAreaControl";

    private static readonly Regex ScriptTagPattern = new(@"<script\b[^>]*>.*?</script\s*>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
    private static readonly Regex EventHandlerAttrPattern = new(@"\s+on\w+\s*=\s*(""[^""]*""|'[^']*'|[^\s>]+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex JavascriptHrefPattern = new(@"(href|src)\s*=\s*(""|')\s*javascript:[^""']*\2", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    public int Rank => 5000;

    public bool ShallMigrate(FieldMigrationContext context)
        => context.SourceDataType.Equals(SourceDataType_LongText, StringComparison.OrdinalIgnoreCase)
        && string.Equals(context.SourceFormControl, SourceFormControl_HtmlArea, StringComparison.OrdinalIgnoreCase);

    public void MigrateFieldDefinition(FormDefinitionPatcher formDefinitionPatcher, XElement field, XAttribute? columnTypeAttr, string fieldDescriptor)
    {
        columnTypeAttr?.SetValue(FieldDataType.RichTextHTML);

        var settings = field.EnsureElement(FormDefinitionPatcher.FieldElemSettings);
        settings.EnsureElement(FormDefinitionPatcher.SettingsElemControlname, e => e.Value = FormComponents.AdminRichTextEditorComponent);
    }

    public Task<FieldMigrationResult> MigrateValue(object? sourceValue, FieldMigrationContext context)
    {
        if (sourceValue is not string html)
        {
            return Task.FromResult(new FieldMigrationResult(true, sourceValue));
        }

        var sanitized = ScriptTagPattern.Replace(html, string.Empty);
        sanitized = EventHandlerAttrPattern.Replace(sanitized, string.Empty);
        sanitized = JavascriptHrefPattern.Replace(sanitized, string.Empty);

        return Task.FromResult(new FieldMigrationResult(true, sanitized));
    }
}

public static class HtmlSanitizationFieldMigrationExtensions
{
    public static IServiceCollection AddHtmlSanitizationMigration(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IFieldMigration>(new HtmlSanitizationFieldMigration());
        return serviceCollection;
    }
}
