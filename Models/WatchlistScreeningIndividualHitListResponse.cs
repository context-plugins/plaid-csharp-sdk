using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Paginated list of individual watchlist screening hits
/// </summary>
public record WatchlistScreeningIndividualHitListResponse
{
    /// <summary>
    /// List of individual watchlist screening hits
    /// </summary>
    [JsonPropertyName("watchlist_screening_hits")]
    public required IReadOnlyList<WatchlistScreeningHit> WatchlistScreeningHits { get; init; }

    /// <summary>
    /// An identifier that determines which page of results you receive.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required string? NextCursor { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
