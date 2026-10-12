using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconDuplicateGet operation.
/// </summary>
public sealed record BeaconDuplicateGetOperationRequest
{
    public required BeaconDuplicateGetRequest Body { get; init; }
}
