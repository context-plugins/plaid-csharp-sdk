using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferLedgerSimulateAvailable operation.
/// </summary>
public sealed record SandboxTransferLedgerSimulateAvailableOperationRequest
{
    public required SandboxTransferLedgerSimulateAvailableRequest Body { get; init; }
}
