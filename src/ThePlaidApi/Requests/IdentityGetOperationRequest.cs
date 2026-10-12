using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityGet operation.
/// </summary>
public sealed record IdentityGetOperationRequest
{
    public required IdentityGetRequest Body { get; init; }
}
