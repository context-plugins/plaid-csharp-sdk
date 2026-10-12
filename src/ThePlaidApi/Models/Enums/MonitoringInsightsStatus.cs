using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum for the status of the insights
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MonitoringInsightsStatus>))]
public sealed record MonitoringInsightsStatus : OpenStringEnum<MonitoringInsightsStatus>
{
    private MonitoringInsightsStatus(string value) : base(value)
    {
    }

    public static readonly MonitoringInsightsStatus Available = new("AVAILABLE");

    public static readonly MonitoringInsightsStatus Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onAvailable, Func<TResult> onFailed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onFailed, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
