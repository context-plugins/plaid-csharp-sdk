using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxItemSetVerificationStatus operation.
/// </summary>
public sealed record SandboxItemSetVerificationStatusOperationRequest
{
    public required SandboxItemSetVerificationStatusRequest Body { get; init; }
}
