using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRecurringCreateResponse defines the response schema for the <c>/transactions/recurring/streams/create</c> endpoint.
/// </summary>
public record TransactionsRecurringCreateResponse
{
    /// <summary>
    /// Streams created as a result of the operation.
    /// </summary>
    [JsonPropertyName("added_streams")]
    public required IReadOnlyList<TransactionStream> AddedStreams { get; init; }

    /// <summary>
    /// Other streams with transactions removed from them as a result of the operation (in no particular order).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modified_streams")]
    public IReadOnlyList<TransactionStream>? ModifiedStreams { get; init; }

    /// <summary>
    /// The ids of streams that are no longer qualified as recurring transaction streams (in no particular order).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("removed_stream_ids")]
    public IReadOnlyList<string>? RemovedStreamIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
