using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualCreate operation.
/// </summary>
public sealed record WatchlistScreeningIndividualCreateOperationRequest
{
    public required WatchlistScreeningIndividualCreateRequest Body { get; init; }
}
