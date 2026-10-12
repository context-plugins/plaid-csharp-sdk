using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferLedgerWithdrawSimulate operation.
/// </summary>
public sealed record SandboxTransferLedgerWithdrawSimulateOperationRequest
{
    public required SandboxTransferLedgerWithdrawSimulateRequest Body { get; init; }
}
