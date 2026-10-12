using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxItemApplicationSeed operation.
/// </summary>
public sealed record SandboxItemApplicationSeedOperationRequest
{
    public required SandboxItemApplicationSeedRequest Body { get; init; }
}
