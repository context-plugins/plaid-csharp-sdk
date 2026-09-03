using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of income. Possible values include:
///   <c>"regular"</c>: regular income
///   <c>"overtime"</c>: overtime income
///   <c>"bonus"</c>: bonus income
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeBreakdownType>))]
public sealed record IncomeBreakdownType : StringEnum<IncomeBreakdownType>
{
    private IncomeBreakdownType(string value) : base(value)
    {
    }

    public static readonly IncomeBreakdownType Bonus = new("bonus");

    public static readonly IncomeBreakdownType Overtime = new("overtime");

    public static readonly IncomeBreakdownType Regular = new("regular");

    public static IncomeBreakdownType FromValue(string value) => FromValueCore(value);
}
