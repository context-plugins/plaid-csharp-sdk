using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Response object for /protect/user/insights/get
/// </summary>
public record ProtectUserInsightsGetResponse
{
    /// <summary>
    /// The Plaid User ID. If a <c>client_user_id</c> was provided in the request instead of a <c>user_id</c>, a new <c>user_id</c> will be generated if one doesn't already exist for that <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The latest scored event for a user.
    /// </summary>
    [JsonPropertyName("latest_scored_event")]
    public required LatestScoredEvent? LatestScoredEvent { get; init; }

    /// <summary>
    /// List of Protect reports associated with this user, limited to the most recent 100 reports in reverse chronological order (newest first).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reports")]
    public IReadOnlyList<ProtectReport>? Reports { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
