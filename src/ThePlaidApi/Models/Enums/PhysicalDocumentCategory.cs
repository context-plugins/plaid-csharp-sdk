using System;
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
public sealed record PhysicalDocumentCategory : OpenStringEnum<PhysicalDocumentCategory>
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

    public TResult Match<TResult>(Func<TResult> onDriversLicense,
        Func<TResult> onIdCard,
        Func<TResult> onPassport,
        Func<TResult> onResidencePermitCard,
        Func<TResult> onResidentCard,
        Func<TResult> onVisa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DriversLicense => onDriversLicense(),
            _ when this == IdCard => onIdCard(),
            _ when this == Passport => onPassport(),
            _ when this == ResidencePermitCard => onResidencePermitCard(),
            _ when this == ResidentCard => onResidentCard(),
            _ when this == Visa => onVisa(),
            _ => otherwise(Value)
        };

    public void Match(Action onDriversLicense,
        Action onIdCard,
        Action onPassport,
        Action onResidencePermitCard,
        Action onResidentCard,
        Action onVisa,
        Action<string> otherwise)
    {
        if (this == DriversLicense) onDriversLicense();
        else if (this == IdCard) onIdCard();
        else if (this == Passport) onPassport();
        else if (this == ResidencePermitCard) onResidencePermitCard();
        else if (this == ResidentCard) onResidentCard();
        else if (this == Visa) onVisa();
        else otherwise(Value);
    }
}
