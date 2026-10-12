using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportBaseReportGet operation.
/// </summary>
public sealed record CraCheckReportBaseReportGetOperationRequest
{
    public required CraCheckReportBaseReportGetRequest Body { get; init; }
}
