using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityHistoryList operation.
/// </summary>
public sealed record WatchlistScreeningEntityHistoryListOperationRequest
{
    public required WatchlistScreeningEntityHistoryListRequest Body { get; init; }
}
