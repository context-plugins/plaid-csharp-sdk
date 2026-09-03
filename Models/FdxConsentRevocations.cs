using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The revocation history of a consent grant. Response body for GET /fdx/consents/{consentId}/revocation.
/// </summary>
public record FdxConsentRevocations
{
    /// <summary>
    /// Revocation records for the consent grant, most recent first. Empty when the grant has never been revoked.
    /// </summary>
    [JsonPropertyName("revocations")]
    public required IReadOnlyList<FdxConsentRevocationRecord> Revocations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
