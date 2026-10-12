using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserUpdate operation.
/// </summary>
public sealed record BeaconUserUpdateOperationRequest
{
    public required BeaconUserUpdateRequest Body { get; init; }
}
