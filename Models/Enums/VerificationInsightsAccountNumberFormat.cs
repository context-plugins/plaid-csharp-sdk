using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicator of account number format validity for institution.
/// <para>
/// <c>valid</c>: indicates that the account number has a correct format for the institution.
/// </para>
/// <para>
/// <c>invalid</c>: indicates that the account number has an incorrect format for the institution.
/// </para>
/// <para>
/// <c>unknown</c>: indicates that there was not enough information to determine whether the format is correct for the institution.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationInsightsAccountNumberFormat>))]
public sealed record VerificationInsightsAccountNumberFormat : StringEnum<VerificationInsightsAccountNumberFormat>
{
    private VerificationInsightsAccountNumberFormat(string value) : base(value)
    {
    }

    public static readonly VerificationInsightsAccountNumberFormat Valid = new("valid");

    public static readonly VerificationInsightsAccountNumberFormat Invalid = new("invalid");

    public static readonly VerificationInsightsAccountNumberFormat Unknown = new("unknown");

    public static VerificationInsightsAccountNumberFormat FromValue(string value) => FromValueCore(value);
}
