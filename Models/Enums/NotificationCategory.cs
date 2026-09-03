using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Category of Notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationCategory>))]
public sealed record NotificationCategory : StringEnum<NotificationCategory>
{
    private NotificationCategory(string value) : base(value)
    {
    }

    public static readonly NotificationCategory Security = new("SECURITY");

    public static readonly NotificationCategory Maintenance = new("MAINTENANCE");

    public static readonly NotificationCategory Fraud = new("FRAUD");

    public static readonly NotificationCategory Consent = new("CONSENT");

    public static readonly NotificationCategory NewData = new("NEW_DATA");

    public static readonly NotificationCategory TokenizedAccountNumber = new("TOKENIZED_ACCOUNT_NUMBER");

    public static NotificationCategory FromValue(string value) => FromValueCore(value);
}
