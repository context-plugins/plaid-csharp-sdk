using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxUserResetLogin operation.
/// </summary>
public sealed record SandboxUserResetLoginOperationRequest
{
    public required SandboxUserResetLoginRequest Body { get; init; }
}
