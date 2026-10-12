using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityProgramList operation.
/// </summary>
public sealed record WatchlistScreeningEntityProgramListOperationRequest
{
    public required WatchlistScreeningEntityProgramListRequest Body { get; init; }
}
