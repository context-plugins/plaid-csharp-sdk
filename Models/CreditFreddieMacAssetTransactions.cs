using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record CreditFreddieMacAssetTransactions
{
    [JsonPropertyName("ASSET_TRANSACTION")]
    public required IReadOnlyList<CreditFreddieMacAssetTransaction> AssetTransaction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
