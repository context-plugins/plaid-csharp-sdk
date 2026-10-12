using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferSweepGet operation.
/// </summary>
public sealed record TransferSweepGetOperationRequest
{
    public required TransferSweepGetRequest Body { get; init; }
}
