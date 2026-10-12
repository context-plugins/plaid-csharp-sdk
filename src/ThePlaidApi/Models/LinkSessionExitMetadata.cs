using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Displayed if a user exits Link without successfully linking an Item.
/// </summary>
public record LinkSessionExitMetadata
{
    /// <summary>
    /// An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution")]
    public LinkSessionExitMetadataInstitution? Institution { get; init; }

    /// <summary>
    /// The point at which the user exited the Link flow. One of the following values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status2? Status { get; init; }

    /// <summary>
    /// A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// The request ID for the last request made by Link. This can be shared with Plaid support to expedite investigation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
