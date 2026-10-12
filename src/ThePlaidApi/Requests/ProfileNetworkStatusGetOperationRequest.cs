using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProfileNetworkStatusGet operation.
/// </summary>
public sealed record ProfileNetworkStatusGetOperationRequest
{
    public required ProfileNetworkStatusGetRequest Body { get; init; }
}
