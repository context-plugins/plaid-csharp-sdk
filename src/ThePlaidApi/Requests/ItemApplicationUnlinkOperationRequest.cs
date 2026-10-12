using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemApplicationUnlink operation.
/// </summary>
public sealed record ItemApplicationUnlinkOperationRequest
{
    public required ItemApplicationUnlinkRequest Body { get; init; }
}
