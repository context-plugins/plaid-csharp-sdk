using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record AssetOwners
{
    /// <summary>
    /// A list of up to 4 account owners' full names.
    /// </summary>
    [JsonPropertyName("ASSET_OWNER")]
    public required IReadOnlyList<AssetOwner> AssetOwner { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
