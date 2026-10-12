using System;
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
public sealed record IncomeBreakdownType : OpenStringEnum<IncomeBreakdownType>
{
    private IncomeBreakdownType(string value) : base(value)
    {
    }

    public static readonly IncomeBreakdownType Bonus = new("bonus");

    public static readonly IncomeBreakdownType Overtime = new("overtime");

    public static readonly IncomeBreakdownType Regular = new("regular");

    public TResult Match<TResult>(Func<TResult> onBonus,
        Func<TResult> onOvertime,
        Func<TResult> onRegular,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bonus => onBonus(),
            _ when this == Overtime => onOvertime(),
            _ when this == Regular => onRegular(),
            _ => otherwise(Value)
        };

    public void Match(Action onBonus, Action onOvertime, Action onRegular, Action<string> otherwise)
    {
        if (this == Bonus) onBonus();
        else if (this == Overtime) onOvertime();
        else if (this == Regular) onRegular();
        else otherwise(Value);
    }
}
