using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualGet operation.
/// </summary>
public sealed record WatchlistScreeningIndividualGetOperationRequest
{
    public required WatchlistScreeningIndividualGetRequest Body { get; init; }
}
