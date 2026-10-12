using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of Notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationType>))]
public sealed record NotificationType : OpenStringEnum<NotificationType>
{
    private NotificationType(string value) : base(value)
    {
    }

    public static readonly NotificationType AccountTakeover = new("ACCOUNT_TAKEOVER");

    public static readonly NotificationType AddressChanged = new("ADDRESS_CHANGED");

    public static readonly NotificationType Balance = new("BALANCE");

    public static readonly NotificationType ConsentExpired = new("CONSENT_EXPIRED");

    public static readonly NotificationType ConsentGranted = new("CONSENT_GRANTED");

    public static readonly NotificationType ConsentRevoked = new("CONSENT_REVOKED");

    public static readonly NotificationType ConsentUpdated = new("CONSENT_UPDATED");

    public static readonly NotificationType Custom = new("CUSTOM");

    public static readonly NotificationType MfaTargetChanged = new("MFA_TARGET_CHANGED");

    public static readonly NotificationType PhoneChanged = new("PHONE_CHANGED");

    public static readonly NotificationType PlannedOutage = new("PLANNED_OUTAGE");

    public static readonly NotificationType Risk = new("RISK");

    public static readonly NotificationType Service = new("SERVICE");

    public static readonly NotificationType SuspectedIncident = new("SUSPECTED_INCIDENT");

    public static readonly NotificationType TanActivated = new("TAN_ACTIVATED");

    public static readonly NotificationType TanCreated = new("TAN_CREATED");

    public static readonly NotificationType TanRevoked = new("TAN_REVOKED");

    public static readonly NotificationType TanSuspended = new("TAN_SUSPENDED");

    public TResult Match<TResult>(Func<TResult> onAccountTakeover,
        Func<TResult> onAddressChanged,
        Func<TResult> onBalance,
        Func<TResult> onConsentExpired,
        Func<TResult> onConsentGranted,
        Func<TResult> onConsentRevoked,
        Func<TResult> onConsentUpdated,
        Func<TResult> onCustom,
        Func<TResult> onMfaTargetChanged,
        Func<TResult> onPhoneChanged,
        Func<TResult> onPlannedOutage,
        Func<TResult> onRisk,
        Func<TResult> onService,
        Func<TResult> onSuspectedIncident,
        Func<TResult> onTanActivated,
        Func<TResult> onTanCreated,
        Func<TResult> onTanRevoked,
        Func<TResult> onTanSuspended,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountTakeover => onAccountTakeover(),
            _ when this == AddressChanged => onAddressChanged(),
            _ when this == Balance => onBalance(),
            _ when this == ConsentExpired => onConsentExpired(),
            _ when this == ConsentGranted => onConsentGranted(),
            _ when this == ConsentRevoked => onConsentRevoked(),
            _ when this == ConsentUpdated => onConsentUpdated(),
            _ when this == Custom => onCustom(),
            _ when this == MfaTargetChanged => onMfaTargetChanged(),
            _ when this == PhoneChanged => onPhoneChanged(),
            _ when this == PlannedOutage => onPlannedOutage(),
            _ when this == Risk => onRisk(),
            _ when this == Service => onService(),
            _ when this == SuspectedIncident => onSuspectedIncident(),
            _ when this == TanActivated => onTanActivated(),
            _ when this == TanCreated => onTanCreated(),
            _ when this == TanRevoked => onTanRevoked(),
            _ when this == TanSuspended => onTanSuspended(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountTakeover,
        Action onAddressChanged,
        Action onBalance,
        Action onConsentExpired,
        Action onConsentGranted,
        Action onConsentRevoked,
        Action onConsentUpdated,
        Action onCustom,
        Action onMfaTargetChanged,
        Action onPhoneChanged,
        Action onPlannedOutage,
        Action onRisk,
        Action onService,
        Action onSuspectedIncident,
        Action onTanActivated,
        Action onTanCreated,
        Action onTanRevoked,
        Action onTanSuspended,
        Action<string> otherwise)
    {
        if (this == AccountTakeover) onAccountTakeover();
        else if (this == AddressChanged) onAddressChanged();
        else if (this == Balance) onBalance();
        else if (this == ConsentExpired) onConsentExpired();
        else if (this == ConsentGranted) onConsentGranted();
        else if (this == ConsentRevoked) onConsentRevoked();
        else if (this == ConsentUpdated) onConsentUpdated();
        else if (this == Custom) onCustom();
        else if (this == MfaTargetChanged) onMfaTargetChanged();
        else if (this == PhoneChanged) onPhoneChanged();
        else if (this == PlannedOutage) onPlannedOutage();
        else if (this == Risk) onRisk();
        else if (this == Service) onService();
        else if (this == SuspectedIncident) onSuspectedIncident();
        else if (this == TanActivated) onTanActivated();
        else if (this == TanCreated) onTanCreated();
        else if (this == TanRevoked) onTanRevoked();
        else if (this == TanSuspended) onTanSuspended();
        else otherwise(Value);
    }
}
