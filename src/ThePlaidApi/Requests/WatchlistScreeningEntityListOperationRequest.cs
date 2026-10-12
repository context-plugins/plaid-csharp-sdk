using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityList operation.
/// </summary>
public sealed record WatchlistScreeningEntityListOperationRequest
{
    public required WatchlistScreeningEntityListRequest Body { get; init; }
}
