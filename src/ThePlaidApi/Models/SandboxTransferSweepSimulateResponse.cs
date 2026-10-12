using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/sandbox/transfer/sweep/simulate</c>
/// </summary>
public record SandboxTransferSweepSimulateResponse
{
    /// <summary>
    /// A sweep returned from the <c>/sandbox/transfer/sweep/simulate</c> endpoint.
    /// Can be null if there are no transfers to include in a sweep.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sweep")]
    public SimulatedTransferSweep? Sweep { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
