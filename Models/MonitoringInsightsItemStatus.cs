using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object with details of the Monitoring Insights Item's status.
/// </summary>
public record MonitoringInsightsItemStatus
{
    /// <summary>
    /// Enum for the status of the Item's insights
    /// </summary>
    [JsonPropertyName("status_code")]
    public required MonitoringItemStatusCode StatusCode { get; init; }

    /// <summary>
    /// A reason for why a Monitoring Insights Report is not available.
    /// This field will only be populated when the <c>status_code</c> is not <c>AVAILABLE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
