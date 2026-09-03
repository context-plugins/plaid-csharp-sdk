using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsEnhanceGetResponse defines the response schema for <c>/beta/transactions/v1/enhance</c>.
/// </summary>
public record TransactionsEnhanceGetResponse
{
    /// <summary>
    /// An array of enhanced transactions.
    /// </summary>
    [JsonPropertyName("enhanced_transactions")]
    public required IReadOnlyList<ClientProvidedEnhancedTransaction> EnhancedTransactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
