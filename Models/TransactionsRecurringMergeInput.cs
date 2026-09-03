using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRecurringMergeInput defines a single input to the <c>/transactions/recurring/streams/merge</c> endpoint.
/// </summary>
public record TransactionsRecurringMergeInput
{
    /// <summary>
    /// IDs of all the streams that will be merged into the first stream. This operation will retain the <c>stream_id</c> of the first stream.
    /// </summary>
    [JsonPropertyName("stream_ids")]
    public required IReadOnlyList<string> StreamIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
