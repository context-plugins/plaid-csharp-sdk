using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferSweepSimulate operation.
/// </summary>
public sealed record SandboxTransferSweepSimulateOperationRequest
{
    public required SandboxTransferSweepSimulateRequest Body { get; init; }
}
