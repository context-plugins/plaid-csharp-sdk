using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletListResponse defines the response schema for <c>/wallet/list</c>
/// </summary>
public record WalletListResponse
{
    /// <summary>
    /// An array of e-wallets
    /// </summary>
    [JsonPropertyName("wallets")]
    public required IReadOnlyList<Wallet> Wallets { get; init; }

    /// <summary>
    /// Cursor used for fetching e-wallets created before the latest e-wallet provided in this response
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
