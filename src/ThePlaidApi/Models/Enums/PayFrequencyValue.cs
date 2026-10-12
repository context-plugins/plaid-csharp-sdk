using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency of the pay period.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayFrequencyValue>))]
public sealed record PayFrequencyValue : OpenStringEnum<PayFrequencyValue>
{
    private PayFrequencyValue(string value) : base(value)
    {
    }

    public static readonly PayFrequencyValue Monthly = new("monthly");

    public static readonly PayFrequencyValue Semimonthly = new("semimonthly");

    public static readonly PayFrequencyValue Weekly = new("weekly");

    public static readonly PayFrequencyValue Biweekly = new("biweekly");

    public static readonly PayFrequencyValue Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onMonthly,
        Func<TResult> onSemimonthly,
        Func<TResult> onWeekly,
        Func<TResult> onBiweekly,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Monthly => onMonthly(),
            _ when this == Semimonthly => onSemimonthly(),
            _ when this == Weekly => onWeekly(),
            _ when this == Biweekly => onBiweekly(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onMonthly,
        Action onSemimonthly,
        Action onWeekly,
        Action onBiweekly,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Monthly) onMonthly();
        else if (this == Semimonthly) onSemimonthly();
        else if (this == Weekly) onWeekly();
        else if (this == Biweekly) onBiweekly();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
