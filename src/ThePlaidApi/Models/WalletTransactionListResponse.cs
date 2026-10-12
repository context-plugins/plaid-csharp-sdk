using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletTransactionListResponse defines the response schema for <c>/wallet/transaction/list</c>
/// </summary>
public record WalletTransactionListResponse
{
    /// <summary>
    /// An array of transactions of an e-wallet, associated with the given <c>wallet_id</c>
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<WalletTransaction> Transactions { get; init; }

    /// <summary>
    /// The value that, when used as the optional <c>cursor</c> parameter to <c>/wallet/transaction/list</c>, will return the corresponding transaction as its first entry.
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
