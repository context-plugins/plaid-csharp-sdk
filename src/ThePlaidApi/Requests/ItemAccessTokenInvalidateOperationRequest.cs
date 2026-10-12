using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemAccessTokenInvalidate operation.
/// </summary>
public sealed record ItemAccessTokenInvalidateOperationRequest
{
    public required ItemAccessTokenInvalidateRequest Body { get; init; }
}
