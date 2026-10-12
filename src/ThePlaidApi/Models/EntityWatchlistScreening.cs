using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The entity screening object allows you to represent an entity in your system, update its profile, and search for it on various watchlists. Note: Rejected entity screenings will not receive new hits, regardless of entity program configuration.
/// </summary>
public record EntityWatchlistScreening
{
    /// <summary>
    /// ID of the associated entity screening.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Search terms associated with an entity used for searching against watchlists
    /// </summary>
    [JsonPropertyName("search_terms")]
    public required EntityWatchlistScreeningSearchTerms SearchTerms { get; init; }

    /// <summary>
    /// ID of the associated user. To retrieve the email address or other details of the person corresponding to this ID, use <c>/dashboard_user/get</c>.
    /// </summary>
    [JsonPropertyName("assignee")]
    public required string? Assignee { get; init; }

    /// <summary>
    /// A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.
    /// </summary>
    [JsonPropertyName("status")]
    public required WatchlistScreeningStatus Status { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string? ClientUserId { get; init; }

    /// <summary>
    /// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
    /// </summary>
    [JsonPropertyName("audit_trail")]
    public required WatchlistScreeningAuditTrail AuditTrail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
