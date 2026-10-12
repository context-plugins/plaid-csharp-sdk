using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRepaymentReturnList operation.
/// </summary>
public sealed record TransferRepaymentReturnListOperationRequest
{
    public required TransferRepaymentReturnListRequest Body { get; init; }
}
