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
public sealed record PaymentInitiationConsentStatus : StringEnum<PaymentInitiationConsentStatus>
{
    private PaymentInitiationConsentStatus(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationConsentStatus Unauthorised = new("UNAUTHORISED");

    public static readonly PaymentInitiationConsentStatus Authorised = new("AUTHORISED");

    public static readonly PaymentInitiationConsentStatus Revoked = new("REVOKED");

    public static readonly PaymentInitiationConsentStatus Rejected = new("REJECTED");

    public static readonly PaymentInitiationConsentStatus Expired = new("EXPIRED");

    public static PaymentInitiationConsentStatus FromValue(string value) => FromValueCore(value);
}
