using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportPdfGet operation.
/// </summary>
public sealed record CraCheckReportPdfGetOperationRequest
{
    public required CraCheckReportPdfGetRequest Body { get; init; }
}
