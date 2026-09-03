using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsEnrichResponse defines the response schema for <c>/transactions/enrich</c>.
/// </summary>
public record TransactionsEnrichResponse
{
    /// <summary>
    /// A list of enriched transactions.
    /// </summary>
    [JsonPropertyName("enriched_transactions")]
    public required IReadOnlyList<ClientProvidedEnrichedTransaction> EnrichedTransactions { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
