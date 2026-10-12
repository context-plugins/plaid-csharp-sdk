using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferSweepList operation.
/// </summary>
public sealed record TransferSweepListOperationRequest
{
    public required TransferSweepListRequest Body { get; init; }
}
