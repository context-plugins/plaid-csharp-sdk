using System;
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
public sealed record PaymentConsentPeriodicAlignment : OpenStringEnum<PaymentConsentPeriodicAlignment>
{
    private PaymentConsentPeriodicAlignment(string value) : base(value)
    {
    }

    public static readonly PaymentConsentPeriodicAlignment Calendar = new("CALENDAR");

    public static readonly PaymentConsentPeriodicAlignment Consent = new("CONSENT");

    public TResult Match<TResult>(Func<TResult> onCalendar, Func<TResult> onConsent, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Calendar => onCalendar(),
            _ when this == Consent => onConsent(),
            _ => otherwise(Value)
        };

    public void Match(Action onCalendar, Action onConsent, Action<string> otherwise)
    {
        if (this == Calendar) onCalendar();
        else if (this == Consent) onConsent();
        else otherwise(Value);
    }
}
