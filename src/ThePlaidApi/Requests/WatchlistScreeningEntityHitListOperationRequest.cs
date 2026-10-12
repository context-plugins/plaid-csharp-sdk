using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityHitList operation.
/// </summary>
public sealed record WatchlistScreeningEntityHitListOperationRequest
{
    public required WatchlistScreeningEntityHitListRequest Body { get; init; }
}
