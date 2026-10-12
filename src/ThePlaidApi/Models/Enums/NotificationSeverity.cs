using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Severity level of notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationSeverity>))]
public sealed record NotificationSeverity : OpenStringEnum<NotificationSeverity>
{
    private NotificationSeverity(string value) : base(value)
    {
    }

    public static readonly NotificationSeverity Emergency = new("EMERGENCY");

    public static readonly NotificationSeverity Alert = new("ALERT");

    public static readonly NotificationSeverity Warning = new("WARNING");

    public static readonly NotificationSeverity Notice = new("NOTICE");

    public static readonly NotificationSeverity Info = new("INFO");

    public TResult Match<TResult>(Func<TResult> onEmergency,
        Func<TResult> onAlert,
        Func<TResult> onWarning,
        Func<TResult> onNotice,
        Func<TResult> onInfo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Emergency => onEmergency(),
            _ when this == Alert => onAlert(),
            _ when this == Warning => onWarning(),
            _ when this == Notice => onNotice(),
            _ when this == Info => onInfo(),
            _ => otherwise(Value)
        };

    public void Match(Action onEmergency,
        Action onAlert,
        Action onWarning,
        Action onNotice,
        Action onInfo,
        Action<string> otherwise)
    {
        if (this == Emergency) onEmergency();
        else if (this == Alert) onAlert();
        else if (this == Warning) onWarning();
        else if (this == Notice) onNotice();
        else if (this == Info) onInfo();
        else otherwise(Value);
    }
}
