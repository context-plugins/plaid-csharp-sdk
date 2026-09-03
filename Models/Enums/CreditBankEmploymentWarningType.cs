using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning type which will always be <c>BANK_EMPLOYMENT_WARNING</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankEmploymentWarningType>))]
public sealed record CreditBankEmploymentWarningType : StringEnum<CreditBankEmploymentWarningType>
{
    private CreditBankEmploymentWarningType(string value) : base(value)
    {
    }

    public static readonly CreditBankEmploymentWarningType BankEmploymentWarning = new("BANK_EMPLOYMENT_WARNING");

    public static CreditBankEmploymentWarningType FromValue(string value) => FromValueCore(value);
}
