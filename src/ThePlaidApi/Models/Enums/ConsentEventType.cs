using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the consent event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventType>))]
public sealed record ConsentEventType : OpenStringEnum<ConsentEventType>
{
    private ConsentEventType(string value) : base(value)
    {
    }

    public static readonly ConsentEventType ConsentGranted = new("CONSENT_GRANTED");

    public static readonly ConsentEventType ConsentRevoked = new("CONSENT_REVOKED");

    public static readonly ConsentEventType ConsentUpdated = new("CONSENT_UPDATED");

    public TResult Match<TResult>(Func<TResult> onConsentGranted,
        Func<TResult> onConsentRevoked,
        Func<TResult> onConsentUpdated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ConsentGranted => onConsentGranted(),
            _ when this == ConsentRevoked => onConsentRevoked(),
            _ when this == ConsentUpdated => onConsentUpdated(),
            _ => otherwise(Value)
        };

    public void Match(Action onConsentGranted,
        Action onConsentRevoked,
        Action onConsentUpdated,
        Action<string> otherwise)
    {
        if (this == ConsentGranted) onConsentGranted();
        else if (this == ConsentRevoked) onConsentRevoked();
        else if (this == ConsentUpdated) onConsentUpdated();
        else otherwise(Value);
    }
}
