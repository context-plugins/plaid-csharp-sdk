using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the NetworkStatusGet operation.
/// </summary>
public sealed record NetworkStatusGetOperationRequest
{
    public required NetworkStatusGetRequest Body { get; init; }
}
