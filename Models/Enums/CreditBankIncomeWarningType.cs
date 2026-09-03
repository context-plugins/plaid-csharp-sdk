using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning type which will always be <c>BANK_INCOME_WARNING</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeWarningType>))]
public sealed record CreditBankIncomeWarningType : StringEnum<CreditBankIncomeWarningType>
{
    private CreditBankIncomeWarningType(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeWarningType BankIncomeWarning = new("BANK_INCOME_WARNING");

    public static CreditBankIncomeWarningType FromValue(string value) => FromValueCore(value);
}
