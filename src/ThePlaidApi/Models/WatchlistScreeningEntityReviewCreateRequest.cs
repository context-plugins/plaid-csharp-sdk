using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for creating a review for an entity screening
/// </summary>
public record WatchlistScreeningEntityReviewCreateRequest
{
    /// <summary>
    /// Hits to mark as a true positive after thorough manual review. These hits will never recur or be updated once confirmed. In most cases, confirmed hits indicate that the customer should be rejected.
    /// </summary>
    [JsonPropertyName("confirmed_hits")]
    public required IReadOnlyList<string> ConfirmedHits { get; init; }

    /// <summary>
    /// Hits to mark as a false positive after thorough manual review. These hits will never recur or be updated once dismissed.
    /// </summary>
    [JsonPropertyName("dismissed_hits")]
    public required IReadOnlyList<string> DismissedHits { get; init; }

    /// <summary>
    /// A comment submitted by a team member as part of reviewing a watchlist screening.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comment")]
    public string? Comment { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// ID of the associated entity screening.
    /// </summary>
    [JsonPropertyName("entity_watchlist_screening_id")]
    public required string EntityWatchlistScreeningId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
