using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetHolder
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("NAME")]
    public required AssetHolderName Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
