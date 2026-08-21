using CMS.DataEngine;
using Microsoft.Extensions.DependencyInjection;
using Migration.Tool.Common.Builders;

namespace Migration.Tool.Extensions.ClassMappings;

/// <summary>
/// Converts the BDO.GlobalLocation custom table into the reusable "global_location" Content hub content type.
/// Field names verified against audit-results/custom-tables.json (real KX13 audit).
///
/// NOTE: This mapping targets a custom table source class. If "BDO.GlobalLocation" is ever added to
/// Settings.ConvertClassesToContentHub in appsettings.json, remove it from that list - EnsureSettings() would
/// otherwise auto-generate a conflicting mapping for the same custom table class (see skill Step 8 / Gotchas).
/// It is currently NOT listed in ConvertClassesToContentHub, so no conflict exists.
/// </summary>
public static class GlobalLocationClassMapping
{
    private const string TargetClassName = "BDO.GlobalLocation";
    private const string SourceClassName = "BDO.GlobalLocation";

    private static MultiClassMapping BuildMapping()
    {
        var m = new MultiClassMapping(TargetClassName, target =>
        {
            target.ClassName = TargetClassName;
            target.ClassTableName = "BDO_GlobalLocation";
            target.ClassDisplayName = "Global Location";
            target.ClassType = ClassType.CONTENT_TYPE;
            target.ClassContentTypeType = ClassContentTypeType.REUSABLE;
            target.ClassWebPageHasUrl = false;
        });

        m.BuildField("GlobalLocationID").AsPrimaryKey();

        m.BuildField("title").SetFrom(SourceClassName, "GlobalLocationTitle", true);
        m.BuildField("address1").SetFrom(SourceClassName, "GlobalLocationAddress1", true);
        m.BuildField("address2").SetFrom(SourceClassName, "GlobalLocationAddress2", true);
        m.BuildField("city").SetFrom(SourceClassName, "GlobalLocationCity", true);
        m.BuildField("state").SetFrom(SourceClassName, "GlobalLocationState", true);
        m.BuildField("country").SetFrom(SourceClassName, "GlobalLocationCountry", true);
        m.BuildField("postalCode").SetFrom(SourceClassName, "GlobalLocationPostalCode", true);
        m.BuildField("latitude").SetFrom(SourceClassName, "GlobalLocationLatitude", true);
        m.BuildField("longitude").SetFrom(SourceClassName, "GlobalLocationLongitude", true);
        m.BuildField("url").SetFrom(SourceClassName, "GlobalLocationUrl", true);
        m.BuildField("memberfirmId").SetFrom(SourceClassName, "MemberFirmID", true);

        // TODO: GlobalLocationRegion is a DropDownListControl storing the raw option value ("1"/"2"/"3" per
        // KX13 Options "1;Americas\n2;EMEA\n3;Asia Pacific"). Confirm with the team whether the target "region"
        // field should keep this raw code or be converted to the display label ("Americas"/"EMEA"/"Asia Pacific")
        // before adding a value-conversion ConvertFrom here.
        m.BuildField("region").SetFrom(SourceClassName, "GlobalLocationRegion", true);

        // TODO: MetadataLocationPinColour is a DropDownListControl whose Options pair an image path with a
        // label ("/App_Themes/Main/pin-marker.png;Red", ".../pin-marker-emerald.png;Emerald"). Confirm the
        // raw stored value (image path vs. label) before adding a value-conversion ConvertFrom here.
        m.BuildField("pinColour").SetFrom(SourceClassName, "MetadataLocationPinColour", true);

        // System/audit fields
        m.BuildField("createdBy").SetFrom(SourceClassName, "ItemCreatedBy", true);
        m.BuildField("createdWhen").SetFrom(SourceClassName, "ItemCreatedWhen", true);
        m.BuildField("modifiedBy").SetFrom(SourceClassName, "ItemModifiedBy", true);
        m.BuildField("modifiedWhen").SetFrom(SourceClassName, "ItemModifiedWhen", true);
        m.BuildField("displayOrder").SetFrom(SourceClassName, "ItemOrder", true);

        return m;
    }

    public static IServiceCollection AddGlobalLocationMapping(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClassMapping>(BuildMapping());
        return serviceCollection;
    }
}
