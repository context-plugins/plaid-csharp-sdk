using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The pay frequency of a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourceFrequency>))]
public sealed record UserStatedIncomeSourceFrequency : OpenStringEnum<UserStatedIncomeSourceFrequency>
{
    private UserStatedIncomeSourceFrequency(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourceFrequency Unknown = new("UNKNOWN");

    public static readonly UserStatedIncomeSourceFrequency Weekly = new("WEEKLY");

    public static readonly UserStatedIncomeSourceFrequency Biweekly = new("BIWEEKLY");

    public static readonly UserStatedIncomeSourceFrequency SemiMonthly = new("SEMI_MONTHLY");

    public static readonly UserStatedIncomeSourceFrequency Monthly = new("MONTHLY");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onWeekly,
        Func<TResult> onBiweekly,
        Func<TResult> onSemiMonthly,
        Func<TResult> onMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Weekly => onWeekly(),
            _ when this == Biweekly => onBiweekly(),
            _ when this == SemiMonthly => onSemiMonthly(),
            _ when this == Monthly => onMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onWeekly,
        Action onBiweekly,
        Action onSemiMonthly,
        Action onMonthly,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Weekly) onWeekly();
        else if (this == Biweekly) onBiweekly();
        else if (this == SemiMonthly) onSemiMonthly();
        else if (this == Monthly) onMonthly();
        else otherwise(Value);
    }
}
