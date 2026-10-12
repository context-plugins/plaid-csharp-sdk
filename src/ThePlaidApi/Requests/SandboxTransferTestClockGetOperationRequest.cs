using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferTestClockGet operation.
/// </summary>
public sealed record SandboxTransferTestClockGetOperationRequest
{
    public required SandboxTransferTestClockGetRequest Body { get; init; }
}
