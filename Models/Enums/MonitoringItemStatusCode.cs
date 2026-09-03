using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum for the status of the Item's insights
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MonitoringItemStatusCode>))]
public sealed record MonitoringItemStatusCode : StringEnum<MonitoringItemStatusCode>
{
    private MonitoringItemStatusCode(string value) : base(value)
    {
    }

    public static readonly MonitoringItemStatusCode Available = new("AVAILABLE");

    public static readonly MonitoringItemStatusCode Failed = new("FAILED");

    public static readonly MonitoringItemStatusCode Pending = new("PENDING");

    public static MonitoringItemStatusCode FromValue(string value) => FromValueCore(value);
}
