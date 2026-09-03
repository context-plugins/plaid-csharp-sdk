using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraMonitoringInsightsGetResponse defines the response schema for <c>/cra/monitoring_insights/get</c>
/// </summary>
public record CraMonitoringInsightsGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A unique ID identifying a User Monitoring Insights Report. Like all Plaid identifiers, this ID is case sensitive.
    /// </summary>
    [JsonPropertyName("user_insights_id")]
    public required string UserInsightsId { get; init; }

    /// <summary>
    /// An array of Monitoring Insights Items associated with the user.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CraMonitoringInsightsItem> Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
