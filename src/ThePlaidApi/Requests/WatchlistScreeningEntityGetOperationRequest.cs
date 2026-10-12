using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityGet operation.
/// </summary>
public sealed record WatchlistScreeningEntityGetOperationRequest
{
    public required WatchlistScreeningEntityGetRequest Body { get; init; }
}
