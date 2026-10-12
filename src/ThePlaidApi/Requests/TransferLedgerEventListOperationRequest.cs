using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferLedgerEventList operation.
/// </summary>
public sealed record TransferLedgerEventListOperationRequest
{
    public required TransferLedgerEventListRequest Body { get; init; }
}
