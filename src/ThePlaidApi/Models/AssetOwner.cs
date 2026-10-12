using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetOwner
{
    /// <summary>
    /// Account Owner Full Name.
    /// </summary>
    [JsonPropertyName("AssetOwnerText")]
    public required string? AssetOwnerText { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
