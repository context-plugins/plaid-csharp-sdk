using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for editing an individual watchlist screening
/// </summary>
public record WatchlistScreeningIndividualUpdateRequest
{
    /// <summary>
    /// ID of the associated screening.
    /// </summary>
    [JsonPropertyName("watchlist_screening_id")]
    public required string WatchlistScreeningId { get; init; }

    /// <summary>
    /// Search terms for editing an individual watchlist screening
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("search_terms")]
    public UpdateIndividualScreeningRequestSearchTerms? SearchTerms { get; init; }

    /// <summary>
    /// ID of the associated user. To retrieve the email address or other details of the person corresponding to this ID, use <c>/dashboard_user/get</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignee")]
    public string? Assignee { get; init; }

    /// <summary>
    /// A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public WatchlistScreeningStatus? Status { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

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
    /// A list of fields to reset back to null
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reset_fields")]
    public IReadOnlyList<WatchlistScreeningIndividualUpdateRequestResettableField>? ResetFields { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
