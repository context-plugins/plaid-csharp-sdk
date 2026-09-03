using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Where the payment consent period should start.
/// <para>
/// If the institution is Monzo, only <c>CONSENT</c> alignments are supported.
/// </para>
/// <para>
/// <c>CALENDAR</c>: line up with a calendar.
/// </para>
/// <para>
/// <c>CONSENT</c>: on the date of consent creation.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentConsentPeriodicAlignment>))]
public sealed record PaymentConsentPeriodicAlignment : StringEnum<PaymentConsentPeriodicAlignment>
{
    private PaymentConsentPeriodicAlignment(string value) : base(value)
    {
    }

    public static readonly PaymentConsentPeriodicAlignment Calendar = new("CALENDAR");

    public static readonly PaymentConsentPeriodicAlignment Consent = new("CONSENT");

    public static PaymentConsentPeriodicAlignment FromValue(string value) => FromValueCore(value);
}
