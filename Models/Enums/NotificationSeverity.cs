using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Severity level of notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationSeverity>))]
public sealed record NotificationSeverity : StringEnum<NotificationSeverity>
{
    private NotificationSeverity(string value) : base(value)
    {
    }

    public static readonly NotificationSeverity Emergency = new("EMERGENCY");

    public static readonly NotificationSeverity Alert = new("ALERT");

    public static readonly NotificationSeverity Warning = new("WARNING");

    public static readonly NotificationSeverity Notice = new("NOTICE");

    public static readonly NotificationSeverity Info = new("INFO");

    public static NotificationSeverity FromValue(string value) => FromValueCore(value);
}
