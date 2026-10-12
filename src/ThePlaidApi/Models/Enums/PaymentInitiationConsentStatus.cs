using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the payment consent.
/// <para>
/// <c>UNAUTHORISED</c>: Consent created, but requires user authorisation.
/// </para>
/// <para>
/// <c>REJECTED</c>: Consent authorisation was rejected by the bank.
/// </para>
/// <para>
/// <c>AUTHORISED</c>: Consent is active and ready to be used.
/// </para>
/// <para>
/// <c>REVOKED</c>: Consent has been revoked and can no longer be used.
/// </para>
/// <para>
/// <c>EXPIRED</c>: Consent is no longer valid.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInitiationConsentStatus>))]
public sealed record PaymentInitiationConsentStatus : OpenStringEnum<PaymentInitiationConsentStatus>
{
    private PaymentInitiationConsentStatus(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationConsentStatus Unauthorised = new("UNAUTHORISED");

    public static readonly PaymentInitiationConsentStatus Authorised = new("AUTHORISED");

    public static readonly PaymentInitiationConsentStatus Revoked = new("REVOKED");

    public static readonly PaymentInitiationConsentStatus Rejected = new("REJECTED");

    public static readonly PaymentInitiationConsentStatus Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onUnauthorised,
        Func<TResult> onAuthorised,
        Func<TResult> onRevoked,
        Func<TResult> onRejected,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unauthorised => onUnauthorised(),
            _ when this == Authorised => onAuthorised(),
            _ when this == Revoked => onRevoked(),
            _ when this == Rejected => onRejected(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnauthorised,
        Action onAuthorised,
        Action onRevoked,
        Action onRejected,
        Action onExpired,
        Action<string> otherwise)
    {
        if (this == Unauthorised) onUnauthorised();
        else if (this == Authorised) onAuthorised();
        else if (this == Revoked) onRevoked();
        else if (this == Rejected) onRejected();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
