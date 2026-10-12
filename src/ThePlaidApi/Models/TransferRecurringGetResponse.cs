using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/recurring/get</c>
/// </summary>
public record TransferRecurringGetResponse
{
    /// <summary>
    /// Represents a recurring transfer within the Transfers API.
    /// </summary>
    [JsonPropertyName("recurring_transfer")]
    public required RecurringTransfer RecurringTransfer { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
