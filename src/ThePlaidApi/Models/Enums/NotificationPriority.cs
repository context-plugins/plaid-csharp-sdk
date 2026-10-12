using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Priority of notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationPriority>))]
public sealed record NotificationPriority : OpenStringEnum<NotificationPriority>
{
    private NotificationPriority(string value) : base(value)
    {
    }

    public static readonly NotificationPriority High = new("HIGH");

    public static readonly NotificationPriority Medium = new("MEDIUM");

    public static readonly NotificationPriority Low = new("LOW");

    public TResult Match<TResult>(Func<TResult> onHigh,
        Func<TResult> onMedium,
        Func<TResult> onLow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == High => onHigh(),
            _ when this == Medium => onMedium(),
            _ when this == Low => onLow(),
            _ => otherwise(Value)
        };

    public void Match(Action onHigh, Action onMedium, Action onLow, Action<string> otherwise)
    {
        if (this == High) onHigh();
        else if (this == Medium) onMedium();
        else if (this == Low) onLow();
        else otherwise(Value);
    }
}
