using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines configuration options to generate Network Insights
/// </summary>
public record CraCheckReportCreateNetworkInsightsOptions
{
    /// <summary>
    /// The version of Network Insights. Required if using Network Insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_insights_version")]
    public NetworkInsightsVersion? NetworkInsightsVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
