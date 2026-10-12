using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityReviewCreate operation.
/// </summary>
public sealed record WatchlistScreeningEntityReviewCreateOperationRequest
{
    public required WatchlistScreeningEntityReviewCreateRequest Body { get; init; }
}
