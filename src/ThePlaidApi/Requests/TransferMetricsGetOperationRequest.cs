using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferMetricsGet operation.
/// </summary>
public sealed record TransferMetricsGetOperationRequest
{
    public required TransferMetricsGetRequest Body { get; init; }
}
