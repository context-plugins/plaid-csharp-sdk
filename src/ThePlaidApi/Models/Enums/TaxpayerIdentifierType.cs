using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that classifies identification numbers used by the Internal Revenue Service (IRS) in the administration of tax laws. A Social Security number (SSN) is issued by the SSA; all other taxpayer identification numbers are issued by the IRS.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxpayerIdentifierType>))]
public sealed record TaxpayerIdentifierType : OpenStringEnum<TaxpayerIdentifierType>
{
    private TaxpayerIdentifierType(string value) : base(value)
    {
    }

    public static readonly TaxpayerIdentifierType IndividualTaxpayerIdentificationNumber = new(
        "IndividualTaxpayerIdentificationNumber");

    public static readonly TaxpayerIdentifierType SocialSecurityNumber = new("SocialSecurityNumber");

    public TResult Match<TResult>(Func<TResult> onIndividualTaxpayerIdentificationNumber,
        Func<TResult> onSocialSecurityNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IndividualTaxpayerIdentificationNumber => onIndividualTaxpayerIdentificationNumber(),
            _ when this == SocialSecurityNumber => onSocialSecurityNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndividualTaxpayerIdentificationNumber,
        Action onSocialSecurityNumber,
        Action<string> otherwise)
    {
        if (this == IndividualTaxpayerIdentificationNumber) onIndividualTaxpayerIdentificationNumber();
        else if (this == SocialSecurityNumber) onSocialSecurityNumber();
        else otherwise(Value);
    }
}
