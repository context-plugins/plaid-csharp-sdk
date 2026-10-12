using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportLendScoreGet operation.
/// </summary>
public sealed record CraCheckReportLendScoreGetOperationRequest
{
    public required CraCheckReportLendScoreGetRequest Body { get; init; }
}
