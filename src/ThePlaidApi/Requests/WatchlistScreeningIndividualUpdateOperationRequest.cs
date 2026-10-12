using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualUpdate operation.
/// </summary>
public sealed record WatchlistScreeningIndividualUpdateOperationRequest
{
    public required WatchlistScreeningIndividualUpdateRequest Body { get; init; }
}
