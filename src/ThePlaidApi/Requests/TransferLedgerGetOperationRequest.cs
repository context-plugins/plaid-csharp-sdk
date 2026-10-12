using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferLedgerGet operation.
/// </summary>
public sealed record TransferLedgerGetOperationRequest
{
    public required TransferLedgerGetRequest Body { get; init; }
}
