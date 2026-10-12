using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing...
/// </summary>
public record CreditFreddieMacAssetTransaction
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ASSET_TRANSACTION_DETAIL")]
    public required AssetTransactionDetail AssetTransactionDetail { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ASSET_TRANSACTION_DESCRIPTION")]
    public required IReadOnlyList<AssetTransactionDescription> AssetTransactionDescription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
