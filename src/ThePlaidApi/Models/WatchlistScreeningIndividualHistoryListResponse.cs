using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Paginated list of individual watchlist screenings.
/// </summary>
public record WatchlistScreeningIndividualHistoryListResponse
{
    /// <summary>
    /// List of individual watchlist screenings
    /// </summary>
    [JsonPropertyName("watchlist_screenings")]
    public required IReadOnlyList<WatchlistScreeningIndividual> WatchlistScreenings { get; init; }

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
