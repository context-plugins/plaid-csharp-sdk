using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferSimulate operation.
/// </summary>
public sealed record SandboxTransferSimulateOperationRequest
{
    public required SandboxTransferSimulateRequest Body { get; init; }
}
