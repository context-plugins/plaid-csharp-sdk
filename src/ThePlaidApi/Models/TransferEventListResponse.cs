using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/event/list</c>
/// </summary>
public record TransferEventListResponse
{
    [JsonPropertyName("transfer_events")]
    public required IReadOnlyList<TransferEvent> TransferEvents { get; init; }

    /// <summary>
    /// Whether there are more events to be pulled from the endpoint that have not already been returned
    /// </summary>
    [JsonPropertyName("has_more")]
    public required bool HasMore { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
