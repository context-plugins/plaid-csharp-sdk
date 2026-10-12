using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferTestClockCreate operation.
/// </summary>
public sealed record SandboxTransferTestClockCreateOperationRequest
{
    public required SandboxTransferTestClockCreateRequest Body { get; init; }
}
