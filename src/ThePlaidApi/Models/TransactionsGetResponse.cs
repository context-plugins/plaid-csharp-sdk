using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsGetResponse defines the response schema for <c>/transactions/get</c>
/// </summary>
public record TransactionsGetResponse
{
    /// <summary>
    /// An array containing the <c>accounts</c> associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the <c>account_id</c> field.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<Account> Accounts { get; init; }

    /// <summary>
    /// An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the <c>count</c> parameter.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<Transaction> Transactions { get; init; }

    /// <summary>
    /// The total number of transactions available within the date range specified. If <c>total_transactions</c> is larger than the size of the <c>transactions</c> array, more transactions are available and can be fetched via manipulating the <c>offset</c> parameter.
    /// </summary>
    [JsonPropertyName("total_transactions")]
    public required int TotalTransactions { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
