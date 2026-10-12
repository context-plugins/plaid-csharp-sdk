using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The resource ID and version number of the template configuring the behavior of a given Identity Verification.
/// </summary>
public record IdentityVerificationTemplateReference
{
    /// <summary>
    /// ID of the associated Identity Verification template. Like all Plaid identifiers, this is case-sensitive.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Version of the associated Identity Verification template.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
