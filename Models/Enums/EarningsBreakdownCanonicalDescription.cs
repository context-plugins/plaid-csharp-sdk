using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Commonly used term to describe the earning line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EarningsBreakdownCanonicalDescription>))]
public sealed record EarningsBreakdownCanonicalDescription : StringEnum<EarningsBreakdownCanonicalDescription>
{
    private EarningsBreakdownCanonicalDescription(string value) : base(value)
    {
    }

    public static readonly EarningsBreakdownCanonicalDescription Bonus = new("BONUS");

    public static readonly EarningsBreakdownCanonicalDescription Commission = new("COMMISSION");

    public static readonly EarningsBreakdownCanonicalDescription Overtime = new("OVERTIME");

    public static readonly EarningsBreakdownCanonicalDescription PaidTimeOff = new("PAID TIME OFF");

    public static readonly EarningsBreakdownCanonicalDescription RegularPay = new("REGULAR PAY");

    public static readonly EarningsBreakdownCanonicalDescription Vacation = new("VACATION");

    public static readonly EarningsBreakdownCanonicalDescription BasicAllowanceHousing = new("BASIC ALLOWANCE HOUSING");

    public static readonly EarningsBreakdownCanonicalDescription BasicAllowanceSubsistence = new("BASIC ALLOWANCE SUBSISTENCE");

    public static readonly EarningsBreakdownCanonicalDescription Other = new("OTHER");

    public static EarningsBreakdownCanonicalDescription FromValue(string value) => FromValueCore(value);
}
