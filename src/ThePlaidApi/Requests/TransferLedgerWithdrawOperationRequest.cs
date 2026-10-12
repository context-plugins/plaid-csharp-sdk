using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferLedgerWithdraw operation.
/// </summary>
public sealed record TransferLedgerWithdrawOperationRequest
{
    public required TransferLedgerWithdrawRequest Body { get; init; }
}
