using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRepaymentList operation.
/// </summary>
public sealed record TransferRepaymentListOperationRequest
{
    public required TransferRepaymentListRequest Body { get; init; }
}
