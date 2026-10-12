using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRecurringUpdateInput defines a single operation to the <c>/transactions/recurring/streams/update</c> endpoint.
/// </summary>
public record TransactionsRecurringUpdateInput
{
    /// <summary>
    /// ID of the stream that all the transactions will be added into.
    /// </summary>
    [JsonPropertyName("stream_id")]
    public required string StreamId { get; init; }

    /// <summary>
    /// IDs of all the transactions that will be added into the stream. If any transaction currently exists in another stream, it will be removed from the other stream.
    /// </summary>
    [JsonPropertyName("transaction_ids")]
    public required IReadOnlyList<string> TransactionIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
