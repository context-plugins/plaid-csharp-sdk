using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Response containing the identifier of the seeded FDX consent grant, which can then be listed, retrieved, and revoked through the FDX Consent API.
/// </summary>
public record SandboxFdxConsentSeedResponse
{
    /// <summary>
    /// The identifier of the newly seeded FDX consent grant.
    /// </summary>
    [JsonPropertyName("consent_id")]
    public required string ConsentId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
