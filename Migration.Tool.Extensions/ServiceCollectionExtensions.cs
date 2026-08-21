using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Extensions.ClassMappings;
using Migration.Tool.Extensions.CommunityMigrations;
using Migration.Tool.Extensions.ContentItemDirectors;
using Migration.Tool.Extensions.DefaultMigrations;
using Migration.Tool.Extensions.FieldMigrations;
using Migration.Tool.KXP.Api.Services.CmsClass;
using Migration.Tool.Source.Mappers.ContentItemMapperDirectives;

namespace Migration.Tool.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection UseCustomizations(this IServiceCollection services)
    {
        services.AddTransient<IFieldMigration, AssetMigration>();
        services.AddTransient<IFieldMigration, SampleTextMigration>();

        // Cross-class HTML sanitization for all HtmlAreaControl/longtext fields (MetadataDescription, Content,
        // SharingInstructions, etc.). Also performs the built-in longtext -> richtexthtml field definition
        // change, so no appsettings.json FieldMigrations entry is needed for HtmlAreaControl fields.
        services.AddHtmlSanitizationMigration();

        // Drop the 6 real KX13 linked pages instead of duplicating them (see LinkedPageDirector.cs).
        services.AddLinkedPageDirector();

        // Drop utility/system pages under /Error-Pages, /Status-Code-Pages, /Reusable-Content-Tab.
        services.AddUtilityPageDirector();

        // Link direct BDO.Insight children of SectionInsightsPage/InsightCategory/InsightGroup as content
        // item references, since Insight becomes reusable and leaves the web page tree.
        services.AddInsightChildLinkDirector();

        services.AddTransient<IWidgetPropertyMigration, WidgetFileMigration>();
        services.AddTransient<IWidgetPropertyMigration, WidgetPathSelectorMigration>();
        services.AddTransient<IWidgetPropertyMigration, WidgetPageSelectorMigration>();


        // Map K13 BDO.Person pages to the existing XbyK BDO.Person page content type
        // Enable only when the target instance already contains BDO.Person.
        // services.AddPersonMapping();

        // Shared metadata schema (title, description, teaserImage, teaserImageAltText, canonicalUrl) - must be
        // registered before any class mapping that calls UseReusableSchema(MetadataFieldsSchema.SchemaName).
        services.AddMetadataFieldsSchema();

        // Convert BDO.Insight (page type) into a reusable Content hub item composed from BDO.MetadataFields.
        services.AddInsightMapping();

        // Remodel the remaining BDO.Metadata/BDO.ContentPage-derived page types (stay webpages) to compose
        // their metadata fields from BDO.MetadataFields. Other own fields keep their names and auto-migrate.
        services.AddNewsArticleMapping();
        services.AddBlogPostMapping();
        services.AddHomePageMapping();
        services.AddEventMapping();
        services.AddServiceAreaMapping();
        services.AddDealMapping();
        services.AddIndustryMapping();
        services.AddInsightCategoryMapping();
        services.AddInsightGroupMapping();
        services.AddSectionInsightsPageMapping();

        // NOTE: BDO.GlobalLocation is a custom table. To migrate it, either:
        //   - Add it to appsettings.json "ConvertClassesToContentHub" and uncomment the line below, OR
        //   - Skip it entirely by not registering a mapping (tool will auto-generate one, but will fail without a PK set)
        // services.AddGlobalLocationMapping();

        // Routing content items to prefabricated content types (i.e., types not created by Migration Tool --page-types CLI argument)
        // services.AddClassMergeExampleAsReusable();
        // services.AddSimpleRemodelingSample();
        // services.AddReusableRemodelingSample();
        // services.AddReusableSchemaIntegrationSample();
        // services.AddReusableSchemaAutoGenerationSample();
        // services.AddTransient<ContentItemDirectorBase, SamplePageToWidgetDirector>();
        // services.AddTransient<ContentItemDirectorBase, SampleChildLinkDirector>();

        // Routing content items to prefabricated content types (i.e., types not created by Migration Tool --page-types CLI argument)
        //
        // The following two methods may be combined, but one particular content type should be covered by only one of them.
        //
        //   1. Content item director method is applicable if each target field has a matching source field that has the same name.
        //      You may use JsonBasedTypeRemapDirector or drive the mapping directly from your own director using IContentItemActionProvider.OverrideTargetType method.
        //
        //      services.AddTransient<ContentItemDirectorBase>(sp => new JsonBasedTypeRemapDirector("migration-mapping.json"));
        //
        //   2. Custom mapping method gives you the highest flexibility if the prefabricated type doesn't match the source type exactly.
        //
        //      services.AddMappingToPrefabricatedContentTypeSample();

        return services;
    }
}
