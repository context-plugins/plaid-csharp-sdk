using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProtectCompute operation.
/// </summary>
public sealed record ProtectComputeOperationRequest
{
    public required ProtectComputeRequest Body { get; init; }
}
