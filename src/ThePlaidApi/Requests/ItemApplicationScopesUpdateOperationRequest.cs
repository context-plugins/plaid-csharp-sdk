using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemApplicationScopesUpdate operation.
/// </summary>
public sealed record ItemApplicationScopesUpdateOperationRequest
{
    public required ItemApplicationScopesUpdateRequest Body { get; init; }
}
