using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferReturnRecover operation.
/// </summary>
public sealed record TransferReturnRecoverOperationRequest
{
    public required TransferReturnRecoverRequest Body { get; init; }
}
