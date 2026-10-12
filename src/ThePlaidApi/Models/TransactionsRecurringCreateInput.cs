using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRecurringCreateInput defines a single input to the <c>/transactions/recurring/streams/create</c> endpoint.
/// </summary>
public record TransactionsRecurringCreateInput
{
    /// <summary>
    /// IDs of all the transactions that will be merged into one stream. If any transaction currently exists in another stream, it will be removed from the other stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_ids")]
    public IReadOnlyList<string>? TransactionIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
