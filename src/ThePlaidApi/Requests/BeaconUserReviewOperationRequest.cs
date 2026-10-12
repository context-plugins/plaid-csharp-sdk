using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserReview operation.
/// </summary>
public sealed record BeaconUserReviewOperationRequest
{
    public required BeaconUserReviewRequest Body { get; init; }
}
