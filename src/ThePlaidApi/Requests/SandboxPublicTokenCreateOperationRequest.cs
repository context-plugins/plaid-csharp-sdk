using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxPublicTokenCreate operation.
/// </summary>
public sealed record SandboxPublicTokenCreateOperationRequest
{
    public required SandboxPublicTokenCreateRequest Body { get; init; }
}
