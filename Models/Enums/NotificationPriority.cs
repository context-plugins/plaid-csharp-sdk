using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Priority of notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationPriority>))]
public sealed record NotificationPriority : StringEnum<NotificationPriority>
{
    private NotificationPriority(string value) : base(value)
    {
    }

    public static readonly NotificationPriority High = new("HIGH");

    public static readonly NotificationPriority Medium = new("MEDIUM");

    public static readonly NotificationPriority Low = new("LOW");

    public static NotificationPriority FromValue(string value) => FromValueCore(value);
}
