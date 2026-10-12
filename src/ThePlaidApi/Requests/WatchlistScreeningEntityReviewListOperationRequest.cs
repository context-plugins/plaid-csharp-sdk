using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityReviewList operation.
/// </summary>
public sealed record WatchlistScreeningEntityReviewListOperationRequest
{
    public required WatchlistScreeningEntityReviewListRequest Body { get; init; }
}
