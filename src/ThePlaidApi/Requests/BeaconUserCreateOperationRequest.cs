using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserCreate operation.
/// </summary>
public sealed record BeaconUserCreateOperationRequest
{
    public required BeaconUserCreateRequest Body { get; init; }
}
