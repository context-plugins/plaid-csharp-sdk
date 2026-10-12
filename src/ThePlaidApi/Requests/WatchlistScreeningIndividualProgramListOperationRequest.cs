using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningIndividualProgramList operation.
/// </summary>
public sealed record WatchlistScreeningIndividualProgramListOperationRequest
{
    public required WatchlistScreeningIndividualProgramListRequest Body { get; init; }
}
