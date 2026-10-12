using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualReviewList operation.
/// </summary>
public sealed record WatchlistScreeningIndividualReviewListOperationRequest
{
    public required WatchlistScreeningIndividualReviewListRequest Body { get; init; }
}
