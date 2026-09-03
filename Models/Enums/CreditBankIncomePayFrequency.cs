using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income pay frequency.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomePayFrequency>))]
public sealed record CreditBankIncomePayFrequency : StringEnum<CreditBankIncomePayFrequency>
{
    private CreditBankIncomePayFrequency(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomePayFrequency Weekly = new("WEEKLY");

    public static readonly CreditBankIncomePayFrequency Biweekly = new("BIWEEKLY");

    public static readonly CreditBankIncomePayFrequency SemiMonthly = new("SEMI_MONTHLY");

    public static readonly CreditBankIncomePayFrequency Monthly = new("MONTHLY");

    public static readonly CreditBankIncomePayFrequency Daily = new("DAILY");

    public static readonly CreditBankIncomePayFrequency Unknown = new("UNKNOWN");

    public static CreditBankIncomePayFrequency FromValue(string value) => FromValueCore(value);
}
