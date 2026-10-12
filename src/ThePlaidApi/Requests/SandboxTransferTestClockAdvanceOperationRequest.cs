using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferTestClockAdvance operation.
/// </summary>
public sealed record SandboxTransferTestClockAdvanceOperationRequest
{
    public required SandboxTransferTestClockAdvanceRequest Body { get; init; }
}
