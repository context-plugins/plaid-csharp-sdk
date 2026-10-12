using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferLedgerDepositSimulate operation.
/// </summary>
public sealed record SandboxTransferLedgerDepositSimulateOperationRequest
{
    public required SandboxTransferLedgerDepositSimulateRequest Body { get; init; }
}
