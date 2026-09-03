using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income pay frequency.
/// <c>WEEKLY</c>: Weekly pay frequency.
/// <c>BIWEEKLY</c>: Biweekly pay frequency.
/// <c>SEMI_MONTHLY</c>: Semi-monthly pay frequency.
/// <c>MONTHLY</c>: Monthly pay frequency.
/// <c>DAILY</c>: Daily pay frequency.
/// <c>UNKNOWN</c>: Pay frequency is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraVerificationIncomePayFrequency>))]
public sealed record CraVerificationIncomePayFrequency : StringEnum<CraVerificationIncomePayFrequency>
{
    private CraVerificationIncomePayFrequency(string value) : base(value)
    {
    }

    public static readonly CraVerificationIncomePayFrequency Weekly = new("WEEKLY");

    public static readonly CraVerificationIncomePayFrequency Biweekly = new("BIWEEKLY");

    public static readonly CraVerificationIncomePayFrequency SemiMonthly = new("SEMI_MONTHLY");

    public static readonly CraVerificationIncomePayFrequency Monthly = new("MONTHLY");

    public static readonly CraVerificationIncomePayFrequency Daily = new("DAILY");

    public static readonly CraVerificationIncomePayFrequency Unknown = new("UNKNOWN");

    public static CraVerificationIncomePayFrequency FromValue(string value) => FromValueCore(value);
}
