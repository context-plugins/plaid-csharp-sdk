using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum for the status of the Item's insights
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MonitoringItemStatusCode>))]
public sealed record MonitoringItemStatusCode : OpenStringEnum<MonitoringItemStatusCode>
{
    private MonitoringItemStatusCode(string value) : base(value)
    {
    }

    public static readonly MonitoringItemStatusCode Available = new("AVAILABLE");

    public static readonly MonitoringItemStatusCode Failed = new("FAILED");

    public static readonly MonitoringItemStatusCode Pending = new("PENDING");

    public TResult Match<TResult>(Func<TResult> onAvailable,
        Func<TResult> onFailed,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == Failed => onFailed(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onFailed, Action onPending, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == Failed) onFailed();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
