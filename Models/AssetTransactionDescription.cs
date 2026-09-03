using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetTransactionDescription
{
    /// <summary>
    /// Asset Transaction Description String up to 3 occurrences 1 required.
    /// </summary>
    [JsonPropertyName("AssetTransactionDescription")]
    public required string AssetTransactionDescriptionValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
