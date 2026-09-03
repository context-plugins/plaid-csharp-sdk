using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// One revocation record on a consent grant, mirroring the FDX ConsentRevocation entity.
/// </summary>
public record FdxConsentRevocationRecord
{
    /// <summary>
    /// Current status of a consent grant. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required FdxConsentGrantStatus Status { get; init; }

    /// <summary>
    /// Reason for lifecycle event status change
    /// </summary>
    [JsonPropertyName("reason")]
    public required FdxUpdateReason Reason { get; init; }

    /// <summary>
    /// Identifies the type of a party
    /// </summary>
    [JsonPropertyName("initiator")]
    public required PartyType Initiator { get; init; }

    /// <summary>
    /// When the consent grant was revoked
    /// </summary>
    [JsonPropertyName("updatedTime")]
    public required DateTimeOffset UpdatedTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
