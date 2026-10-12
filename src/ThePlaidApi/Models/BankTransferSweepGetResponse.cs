using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// BankTransferSweepGetResponse defines the response schema for <c>/bank_transfer/sweep/get</c>
/// </summary>
public record BankTransferSweepGetResponse
{
    /// <summary>
    /// BankTransferSweep describes a sweep transfer.
    /// </summary>
    [JsonPropertyName("sweep")]
    public required BankTransferSweep Sweep { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
