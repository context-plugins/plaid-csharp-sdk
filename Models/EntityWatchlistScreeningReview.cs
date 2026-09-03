using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A review submitted by a team member for an entity watchlist screening. A review can be either a comment on the current screening state, actions taken
/// against hits attached to the watchlist screening, or both.
/// </summary>
public record EntityWatchlistScreeningReview
{
    /// <summary>
    /// ID of the associated entity review.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Hits marked as a true positive after thorough manual review. These hits will never recur or be updated once confirmed. In most cases, confirmed hits indicate that the customer should be rejected.
    /// </summary>
    [JsonPropertyName("confirmed_hits")]
    public required IReadOnlyList<string> ConfirmedHits { get; init; }

    /// <summary>
    /// Hits marked as a false positive after thorough manual review. These hits will never recur or be updated once dismissed.
    /// </summary>
    [JsonPropertyName("dismissed_hits")]
    public required IReadOnlyList<string> DismissedHits { get; init; }

    /// <summary>
    /// A comment submitted by a team member as part of reviewing a watchlist screening.
    /// </summary>
    [JsonPropertyName("comment")]
    public required string? Comment { get; init; }

    /// <summary>
    /// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
    /// </summary>
    [JsonPropertyName("audit_trail")]
    public required WatchlistScreeningAuditTrail AuditTrail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
