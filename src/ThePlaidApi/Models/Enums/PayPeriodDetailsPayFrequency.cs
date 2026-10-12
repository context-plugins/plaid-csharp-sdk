using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency at which an individual is paid.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayPeriodDetailsPayFrequency>))]
public sealed record PayPeriodDetailsPayFrequency : OpenStringEnum<PayPeriodDetailsPayFrequency>
{
    private PayPeriodDetailsPayFrequency(string value) : base(value)
    {
    }

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyUnknown = new("PAY_FREQUENCY_UNKNOWN");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyWeekly = new("PAY_FREQUENCY_WEEKLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyBiweekly = new("PAY_FREQUENCY_BIWEEKLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencySemimonthly = new("PAY_FREQUENCY_SEMIMONTHLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyMonthly = new("PAY_FREQUENCY_MONTHLY");

    public TResult Match<TResult>(Func<TResult> onPayFrequencyUnknown,
        Func<TResult> onPayFrequencyWeekly,
        Func<TResult> onPayFrequencyBiweekly,
        Func<TResult> onPayFrequencySemimonthly,
        Func<TResult> onPayFrequencyMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PayFrequencyUnknown => onPayFrequencyUnknown(),
            _ when this == PayFrequencyWeekly => onPayFrequencyWeekly(),
            _ when this == PayFrequencyBiweekly => onPayFrequencyBiweekly(),
            _ when this == PayFrequencySemimonthly => onPayFrequencySemimonthly(),
            _ when this == PayFrequencyMonthly => onPayFrequencyMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayFrequencyUnknown,
        Action onPayFrequencyWeekly,
        Action onPayFrequencyBiweekly,
        Action onPayFrequencySemimonthly,
        Action onPayFrequencyMonthly,
        Action<string> otherwise)
    {
        if (this == PayFrequencyUnknown) onPayFrequencyUnknown();
        else if (this == PayFrequencyWeekly) onPayFrequencyWeekly();
        else if (this == PayFrequencyBiweekly) onPayFrequencyBiweekly();
        else if (this == PayFrequencySemimonthly) onPayFrequencySemimonthly();
        else if (this == PayFrequencyMonthly) onPayFrequencyMonthly();
        else otherwise(Value);
    }
}
