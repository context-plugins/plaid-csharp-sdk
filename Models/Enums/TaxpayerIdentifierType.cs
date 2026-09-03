using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that classifies identification numbers used by the Internal Revenue Service (IRS) in the administration of tax laws. A Social Security number (SSN) is issued by the SSA; all other taxpayer identification numbers are issued by the IRS.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxpayerIdentifierType>))]
public sealed record TaxpayerIdentifierType : StringEnum<TaxpayerIdentifierType>
{
    private TaxpayerIdentifierType(string value) : base(value)
    {
    }

    public static readonly TaxpayerIdentifierType IndividualTaxpayerIdentificationNumber = new("IndividualTaxpayerIdentificationNumber");

    public static readonly TaxpayerIdentifierType SocialSecurityNumber = new("SocialSecurityNumber");

    public static TaxpayerIdentifierType FromValue(string value) => FromValueCore(value);
}
