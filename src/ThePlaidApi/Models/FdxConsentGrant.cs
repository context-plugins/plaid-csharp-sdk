using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An FDX consent grant.
/// </summary>
public record FdxConsentGrant
{
    /// <summary>
    /// The persistent identifier of the consent grant
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Current status of a consent grant. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required FdxConsentGrantStatus Status { get; init; }

    /// <summary>
    /// When the consent was initially granted
    /// </summary>
    [JsonPropertyName("createdTime")]
    public required DateTimeOffset CreatedTime { get; init; }

    /// <summary>
    /// When the consent grant was last updated
    /// </summary>
    [JsonPropertyName("updatedTime")]
    public required DateTimeOffset UpdatedTime { get; init; }

    /// <summary>
    /// When the consent grant will expire. Omitted when the grant has no expiration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationTime")]
    public DateTimeOffset? ExpirationTime { get; init; }

    /// <summary>
    /// Non-end-user parties participating in the consent grant (Data Recipient, Data Provider, Data Access Platform).
    /// </summary>
    [JsonPropertyName("parties")]
    public required IReadOnlyList<PartyEntity> Parties { get; init; }

    /// <summary>
    /// Permissioned resource entries. Omitted when there are no resources.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resources")]
    public IReadOnlyList<FdxConsentGrantResource>? Resources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
