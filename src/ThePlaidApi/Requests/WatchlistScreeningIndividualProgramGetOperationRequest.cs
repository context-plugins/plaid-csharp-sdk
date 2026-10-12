using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualProgramGet operation.
/// </summary>
public sealed record WatchlistScreeningIndividualProgramGetOperationRequest
{
    public required WatchlistScreeningIndividualProgramGetRequest Body { get; init; }
}
