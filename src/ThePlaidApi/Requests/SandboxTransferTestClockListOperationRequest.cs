using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferTestClockList operation.
/// </summary>
public sealed record SandboxTransferTestClockListOperationRequest
{
    public required SandboxTransferTestClockListRequest Body { get; init; }
}
