using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserAccountInsightsGet operation.
/// </summary>
public sealed record BeaconUserAccountInsightsGetOperationRequest
{
    public required BeaconUserAccountInsightsGetRequest Body { get; init; }
}
