using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata that captures information about the Auth features of an institution.
/// </summary>
public record AuthMetadata
{
    /// <summary>
    /// Metadata specifically related to which auth methods an institution supports.
    /// </summary>
    [JsonPropertyName("supported_methods")]
    public required AuthSupportedMethods? SupportedMethods { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
