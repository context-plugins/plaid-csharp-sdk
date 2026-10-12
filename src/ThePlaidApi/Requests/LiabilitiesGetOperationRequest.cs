using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the LiabilitiesGet operation.
/// </summary>
public sealed record LiabilitiesGetOperationRequest
{
    public required LiabilitiesGetRequest Body { get; init; }
}
