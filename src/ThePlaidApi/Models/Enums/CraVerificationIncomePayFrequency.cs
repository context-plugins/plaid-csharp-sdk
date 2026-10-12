using System;
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
public sealed record CraVerificationIncomePayFrequency : OpenStringEnum<CraVerificationIncomePayFrequency>
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

    public TResult Match<TResult>(Func<TResult> onWeekly,
        Func<TResult> onBiweekly,
        Func<TResult> onSemiMonthly,
        Func<TResult> onMonthly,
        Func<TResult> onDaily,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Weekly => onWeekly(),
            _ when this == Biweekly => onBiweekly(),
            _ when this == SemiMonthly => onSemiMonthly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Daily => onDaily(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeekly,
        Action onBiweekly,
        Action onSemiMonthly,
        Action onMonthly,
        Action onDaily,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Weekly) onWeekly();
        else if (this == Biweekly) onBiweekly();
        else if (this == SemiMonthly) onSemiMonthly();
        else if (this == Monthly) onMonthly();
        else if (this == Daily) onDaily();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
