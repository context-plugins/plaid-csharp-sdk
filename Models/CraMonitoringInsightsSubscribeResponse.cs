using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraMonitoringInsightsSubscribeResponse defines the response schema for <c>/cra/monitoring_insights/subscribe</c>
/// </summary>
public record CraMonitoringInsightsSubscribeResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A unique identifier for the subscription.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public required string SubscriptionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
