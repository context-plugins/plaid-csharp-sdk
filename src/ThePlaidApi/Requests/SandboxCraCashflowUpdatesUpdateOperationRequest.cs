using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxCraCashflowUpdatesUpdate operation.
/// </summary>
public sealed record SandboxCraCashflowUpdatesUpdateOperationRequest
{
    public required SandboxCraCashflowUpdatesUpdateRequest Body { get; init; }
}
