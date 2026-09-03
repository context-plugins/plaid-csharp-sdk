using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Payment consent periodic interval.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentConsentPeriodicInterval>))]
public sealed record PaymentConsentPeriodicInterval : StringEnum<PaymentConsentPeriodicInterval>
{
    private PaymentConsentPeriodicInterval(string value) : base(value)
    {
    }

    public static readonly PaymentConsentPeriodicInterval Day = new("DAY");

    public static readonly PaymentConsentPeriodicInterval Week = new("WEEK");

    public static readonly PaymentConsentPeriodicInterval Month = new("MONTH");

    public static readonly PaymentConsentPeriodicInterval Year = new("YEAR");

    public static PaymentConsentPeriodicInterval FromValue(string value) => FromValueCore(value);
}
