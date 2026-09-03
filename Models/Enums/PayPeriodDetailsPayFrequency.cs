using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency at which an individual is paid.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayPeriodDetailsPayFrequency>))]
public sealed record PayPeriodDetailsPayFrequency : StringEnum<PayPeriodDetailsPayFrequency>
{
    private PayPeriodDetailsPayFrequency(string value) : base(value)
    {
    }

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyUnknown = new("PAY_FREQUENCY_UNKNOWN");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyWeekly = new("PAY_FREQUENCY_WEEKLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyBiweekly = new("PAY_FREQUENCY_BIWEEKLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencySemimonthly = new("PAY_FREQUENCY_SEMIMONTHLY");

    public static readonly PayPeriodDetailsPayFrequency PayFrequencyMonthly = new("PAY_FREQUENCY_MONTHLY");

    public static PayPeriodDetailsPayFrequency FromValue(string value) => FromValueCore(value);
}
