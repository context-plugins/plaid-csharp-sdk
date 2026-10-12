using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetHolderName
{
    /// <summary>
    /// The unparsed name of either an individual or a legal entity.
    /// </summary>
    [JsonPropertyName("FullName")]
    public required string FullName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
