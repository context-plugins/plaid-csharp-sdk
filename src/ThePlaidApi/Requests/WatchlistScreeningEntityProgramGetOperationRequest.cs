using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityProgramGet operation.
/// </summary>
public sealed record WatchlistScreeningEntityProgramGetOperationRequest
{
    public required WatchlistScreeningEntityProgramGetRequest Body { get; init; }
}
