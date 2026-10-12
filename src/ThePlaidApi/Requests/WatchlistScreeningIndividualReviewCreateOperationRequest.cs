using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualReviewCreate operation.
/// </summary>
public sealed record WatchlistScreeningIndividualReviewCreateOperationRequest
{
    public required WatchlistScreeningIndividualReviewCreateRequest Body { get; init; }
}
