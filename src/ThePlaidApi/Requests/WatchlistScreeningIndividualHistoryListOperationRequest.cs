using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualHistoryList operation.
/// </summary>
public sealed record WatchlistScreeningIndividualHistoryListOperationRequest
{
    public required WatchlistScreeningIndividualHistoryListRequest Body { get; init; }
}
