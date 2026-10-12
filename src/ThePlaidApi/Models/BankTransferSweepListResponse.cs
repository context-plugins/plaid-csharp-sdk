using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// BankTransferSweepListResponse defines the response schema for <c>/bank_transfer/sweep/list</c>
/// </summary>
public record BankTransferSweepListResponse
{
    [JsonPropertyName("sweeps")]
    public required IReadOnlyList<BankTransferSweep> Sweeps { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
