using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Payment consent periodic interval.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentConsentPeriodicInterval>))]
public sealed record PaymentConsentPeriodicInterval : OpenStringEnum<PaymentConsentPeriodicInterval>
{
    private PaymentConsentPeriodicInterval(string value) : base(value)
    {
    }

    public static readonly PaymentConsentPeriodicInterval Day = new("DAY");

    public static readonly PaymentConsentPeriodicInterval Week = new("WEEK");

    public static readonly PaymentConsentPeriodicInterval Month = new("MONTH");

    public static readonly PaymentConsentPeriodicInterval Year = new("YEAR");

    public TResult Match<TResult>(Func<TResult> onDay,
        Func<TResult> onWeek,
        Func<TResult> onMonth,
        Func<TResult> onYear,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Day => onDay(),
            _ when this == Week => onWeek(),
            _ when this == Month => onMonth(),
            _ when this == Year => onYear(),
            _ => otherwise(Value)
        };

    public void Match(Action onDay, Action onWeek, Action onMonth, Action onYear, Action<string> otherwise)
    {
        if (this == Day) onDay();
        else if (this == Week) onWeek();
        else if (this == Month) onMonth();
        else if (this == Year) onYear();
        else otherwise(Value);
    }
}
