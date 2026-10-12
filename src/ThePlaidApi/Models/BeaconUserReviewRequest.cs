using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for updating the status of a Beacon User
/// </summary>
public record BeaconUserReviewRequest
{
    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string BeaconUserId { get; init; }

    /// <summary>
    /// A status of a Beacon User.
    /// <para>
    /// <c>rejected</c>: The Beacon User has been rejected for fraud. Users can be automatically or manually rejected.
    /// </para>
    /// <para>
    /// <c>pending_review</c>: The Beacon User has been marked for review.
    /// </para>
    /// <para>
    /// <c>cleared</c>: The Beacon User has been cleared of fraud.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required BeaconUserStatus Status { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
