using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum for the status of the insights
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MonitoringInsightsStatus>))]
public sealed record MonitoringInsightsStatus : StringEnum<MonitoringInsightsStatus>
{
    private MonitoringInsightsStatus(string value) : base(value)
    {
    }

    public static readonly MonitoringInsightsStatus Available = new("AVAILABLE");

    public static readonly MonitoringInsightsStatus Failed = new("FAILED");

    public static MonitoringInsightsStatus FromValue(string value) => FromValueCore(value);
}
