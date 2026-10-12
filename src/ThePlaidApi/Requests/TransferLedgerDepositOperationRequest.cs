using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferLedgerDeposit operation.
/// </summary>
public sealed record TransferLedgerDepositOperationRequest
{
    public required TransferLedgerDepositRequest Body { get; init; }
}
