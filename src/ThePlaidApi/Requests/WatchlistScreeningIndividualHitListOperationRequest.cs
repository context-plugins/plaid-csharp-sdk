using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualHitList operation.
/// </summary>
public sealed record WatchlistScreeningIndividualHitListOperationRequest
{
    public required WatchlistScreeningIndividualHitListRequest Body { get; init; }
}
