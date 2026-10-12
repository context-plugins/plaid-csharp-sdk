using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRefundCancel operation.
/// </summary>
public sealed record TransferRefundCancelOperationRequest
{
    public required TransferRefundCancelRequest Body { get; init; }
}
