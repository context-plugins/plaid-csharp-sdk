using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxFdxConsentSeed operation.
/// </summary>
public sealed record SandboxFdxConsentSeedOperationRequest
{
    public required SandboxFdxConsentSeedRequest Body { get; init; }
}
