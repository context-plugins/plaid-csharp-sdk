using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of identity document detected in the images provided. Will always be one of the following values:
/// <para>
///   <c>drivers_license</c> - A driver's license issued by the associated country, establishing identity without any guarantee as to citizenship, and granting driving privileges
/// </para>
/// <para>
///   <c>id_card</c> - A general national identification card, distinct from driver's licenses as it only establishes identity
/// </para>
/// <para>
///   <c>passport</c> - A travel passport issued by the associated country for one of its citizens
/// </para>
/// <para>
///   <c>residence_permit_card</c> - An identity document issued by the associated country permitting a foreign citizen to &lt;em&gt;temporarily&lt;/em&gt; reside there
/// </para>
/// <para>
///   <c>resident_card</c> - An identity document issued by the associated country permitting a foreign citizen to &lt;em&gt;permanently&lt;/em&gt; reside there
/// </para>
/// <para>
///   <c>visa</c> - An identity document issued by the associated country permitting a foreign citizen entry for a short duration and for a specific purpose, typically no longer than 6 months
/// </para>
/// <para>
/// Note: This value may be different from the ID type that the user selects within Link. For example, if they select "Driver's License" but then submit a picture of a passport, this field will say <c>passport</c>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhysicalDocumentCategory>))]
public sealed record PhysicalDocumentCategory : StringEnum<PhysicalDocumentCategory>
{
    private PhysicalDocumentCategory(string value) : base(value)
    {
    }

    public static readonly PhysicalDocumentCategory DriversLicense = new("drivers_license");

    public static readonly PhysicalDocumentCategory IdCard = new("id_card");

    public static readonly PhysicalDocumentCategory Passport = new("passport");

    public static readonly PhysicalDocumentCategory ResidencePermitCard = new("residence_permit_card");

    public static readonly PhysicalDocumentCategory ResidentCard = new("resident_card");

    public static readonly PhysicalDocumentCategory Visa = new("visa");

    public static PhysicalDocumentCategory FromValue(string value) => FromValueCore(value);
}
