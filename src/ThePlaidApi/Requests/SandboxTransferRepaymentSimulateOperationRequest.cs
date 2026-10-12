using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferRepaymentSimulate operation.
/// </summary>
public sealed record SandboxTransferRepaymentSimulateOperationRequest
{
    public required SandboxTransferRepaymentSimulateRequest Body { get; init; }
}
