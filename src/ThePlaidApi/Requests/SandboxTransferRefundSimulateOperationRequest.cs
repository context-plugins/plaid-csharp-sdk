using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferRefundSimulate operation.
/// </summary>
public sealed record SandboxTransferRefundSimulateOperationRequest
{
    public required SandboxTransferRefundSimulateRequest Body { get; init; }
}
