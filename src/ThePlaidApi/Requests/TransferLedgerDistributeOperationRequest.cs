using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferLedgerDistribute operation.
/// </summary>
public sealed record TransferLedgerDistributeOperationRequest
{
    public required TransferLedgerDistributeRequest Body { get; init; }
}
