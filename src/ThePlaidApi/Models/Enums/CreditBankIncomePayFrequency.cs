using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income pay frequency.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomePayFrequency>))]
public sealed record CreditBankIncomePayFrequency : OpenStringEnum<CreditBankIncomePayFrequency>
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
