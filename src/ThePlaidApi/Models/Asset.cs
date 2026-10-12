using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record Asset
{
    /// <summary>
    /// Details about an asset.
    /// </summary>
    [JsonPropertyName("ASSET_DETAIL")]
    public required AssetDetail AssetDetail { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ASSET_OWNERS")]
    public required AssetOwners AssetOwners { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ASSET_HOLDER")]
    public required AssetHolder AssetHolder { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ASSET_TRANSACTIONS")]
    public required AssetTransactions AssetTransactions { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("VALIDATION_SOURCES")]
    public required ValidationSources ValidationSources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
