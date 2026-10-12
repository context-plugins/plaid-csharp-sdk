using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemRemove operation.
/// </summary>
public sealed record ItemRemoveOperationRequest
{
    public required ItemRemoveRequest Body { get; init; }
}
