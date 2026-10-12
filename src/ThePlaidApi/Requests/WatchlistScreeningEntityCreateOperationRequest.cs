using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityCreate operation.
/// </summary>
public sealed record WatchlistScreeningEntityCreateOperationRequest
{
    public required WatchlistScreeningEntityCreateRequest Body { get; init; }
}
