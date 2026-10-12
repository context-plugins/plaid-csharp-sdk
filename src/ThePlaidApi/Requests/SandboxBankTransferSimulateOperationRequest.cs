using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxBankTransferSimulate operation.
/// </summary>
public sealed record SandboxBankTransferSimulateOperationRequest
{
    public required SandboxBankTransferSimulateRequest Body { get; init; }
}
