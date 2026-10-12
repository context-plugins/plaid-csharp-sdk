using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency interval of the payment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentScheduleInterval>))]
public sealed record PaymentScheduleInterval : OpenStringEnum<PaymentScheduleInterval>
{
    private PaymentScheduleInterval(string value) : base(value)
    {
    }

    public static readonly PaymentScheduleInterval Weekly = new("WEEKLY");

    public static readonly PaymentScheduleInterval Monthly = new("MONTHLY");

    public TResult Match<TResult>(Func<TResult> onWeekly, Func<TResult> onMonthly, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeekly, Action onMonthly, Action<string> otherwise)
    {
        if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else otherwise(Value);
    }
}
