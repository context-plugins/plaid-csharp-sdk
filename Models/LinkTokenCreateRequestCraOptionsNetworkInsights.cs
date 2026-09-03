using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the CRA Network Insights product.
/// </summary>
public record LinkTokenCreateRequestCraOptionsNetworkInsights
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
