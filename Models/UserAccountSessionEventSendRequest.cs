using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserAccountSessionEventSendRequest defines the request schema for <c>/user_account/session/event/send</c>
/// </summary>
public record UserAccountSessionEventSendRequest
{
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
    /// Optional cohort identifier for the user session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cohort_id")]
    public string? CohortId { get; init; }

    /// <summary>
    /// The Link session identifier.
    /// </summary>
    [JsonPropertyName("link_session_id")]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// Event data for user account session tracking
    /// </summary>
    [JsonPropertyName("event")]
    public required UserAccountSessionEvent Event { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
