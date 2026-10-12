using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency of a loan's payment schedule.
/// <c>BIWEEKLY</c> represents one payment every two weeks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanPaymentSchedule>))]
public sealed record CraLoanPaymentSchedule : OpenStringEnum<CraLoanPaymentSchedule>
{
    private CraLoanPaymentSchedule(string value) : base(value)
    {
    }

    public static readonly CraLoanPaymentSchedule Daily = new("DAILY");

    public static readonly CraLoanPaymentSchedule Weekly = new("WEEKLY");

    public static readonly CraLoanPaymentSchedule Biweekly = new("BIWEEKLY");

    public static readonly CraLoanPaymentSchedule Monthly = new("MONTHLY");

    public static readonly CraLoanPaymentSchedule Quarterly = new("QUARTERLY");

    public static readonly CraLoanPaymentSchedule Annually = new("ANNUALLY");

    public static readonly CraLoanPaymentSchedule Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onBiweekly,
        Func<TResult> onMonthly,
        Func<TResult> onQuarterly,
        Func<TResult> onAnnually,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Biweekly => onBiweekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Quarterly => onQuarterly(),
            _ when this == Annually => onAnnually(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily,
        Action onWeekly,
        Action onBiweekly,
        Action onMonthly,
        Action onQuarterly,
        Action onAnnually,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Biweekly) onBiweekly();
        else if (this == Monthly) onMonthly();
        else if (this == Quarterly) onQuarterly();
        else if (this == Annually) onAnnually();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
