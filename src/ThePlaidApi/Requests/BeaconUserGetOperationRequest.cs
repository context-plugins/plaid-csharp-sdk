using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserGet operation.
/// </summary>
public sealed record BeaconUserGetOperationRequest
{
    public required BeaconUserGetRequest Body { get; init; }
}
