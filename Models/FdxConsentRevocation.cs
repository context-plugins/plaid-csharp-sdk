using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request body for PUT /fdx/consents/{consentId}/revocation.
/// </summary>
public record FdxConsentRevocation
{
    /// <summary>
    /// Identifies the type of a party
    /// </summary>
    [JsonPropertyName("initiator")]
    public required PartyType Initiator { get; init; }

    /// <summary>
    /// Reason for lifecycle event status change
    /// </summary>
    [JsonPropertyName("reason")]
    public required FdxUpdateReason Reason { get; init; }

    /// <summary>
    /// Additional information or description of an <c>OTHER</c> reason
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherReason")]
    public string? OtherReason { get; init; }

    /// <summary>
    /// When the revocation was effected on the initiator's side
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedTime")]
    public DateTimeOffset? UpdatedTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
