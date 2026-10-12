using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraReportGet operation.
/// </summary>
public sealed record CraReportGetOperationRequest
{
    public required CraReportGetRequest Body { get; init; }
}
