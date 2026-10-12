using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency at which the employee is paid. Possible values: <c>MONTHLY</c>, <c>BI-WEEKLY</c>, <c>WEEKLY</c>, <c>SEMI-MONTHLY</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaystubPayFrequency>))]
public sealed record PaystubPayFrequency : OpenStringEnum<PaystubPayFrequency>
{
    private PaystubPayFrequency(string value) : base(value)
    {
    }

    public static readonly PaystubPayFrequency Monthly = new("MONTHLY");

    public static readonly PaystubPayFrequency BiWeekly = new("BI-WEEKLY");

    public static readonly PaystubPayFrequency Weekly = new("WEEKLY");

    public static readonly PaystubPayFrequency SemiMonthly = new("SEMI-MONTHLY");

    public TResult Match<TResult>(Func<TResult> onMonthly,
        Func<TResult> onBiWeekly,
        Func<TResult> onWeekly,
        Func<TResult> onSemiMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Monthly => onMonthly(),
            _ when this == BiWeekly => onBiWeekly(),
            _ when this == Weekly => onWeekly(),
            _ when this == SemiMonthly => onSemiMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onMonthly,
        Action onBiWeekly,
        Action onWeekly,
        Action onSemiMonthly,
        Action<string> otherwise)
    {
        if (this == Monthly) onMonthly();
        else if (this == BiWeekly) onBiWeekly();
        else if (this == Weekly) onWeekly();
        else if (this == SemiMonthly) onSemiMonthly();
        else otherwise(Value);
    }
}
