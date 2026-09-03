using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of entity causing origination of a notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationPayloadIdType>))]
public sealed record NotificationPayloadIdType : StringEnum<NotificationPayloadIdType>
{
    private NotificationPayloadIdType(string value) : base(value)
    {
    }

    public static readonly NotificationPayloadIdType Account = new("ACCOUNT");

    public static readonly NotificationPayloadIdType Customer = new("CUSTOMER");

    public static readonly NotificationPayloadIdType Party = new("PARTY");

    public static readonly NotificationPayloadIdType Maintenance = new("MAINTENANCE");

    public static readonly NotificationPayloadIdType Consent = new("CONSENT");

    public static NotificationPayloadIdType FromValue(string value) => FromValueCore(value);
}
