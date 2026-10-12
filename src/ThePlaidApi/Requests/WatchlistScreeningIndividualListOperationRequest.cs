using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualList operation.
/// </summary>
public sealed record WatchlistScreeningIndividualListOperationRequest
{
    public required WatchlistScreeningIndividualListRequest Body { get; init; }
}
