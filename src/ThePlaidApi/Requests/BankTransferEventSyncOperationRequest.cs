using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferEventSync operation.
/// </summary>
public sealed record BankTransferEventSyncOperationRequest
{
    public required BankTransferEventSyncRequest Body { get; init; }
}
