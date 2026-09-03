using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of Notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationType>))]
public sealed record NotificationType : StringEnum<NotificationType>
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

    public static NotificationType FromValue(string value) => FromValueCore(value);
}
