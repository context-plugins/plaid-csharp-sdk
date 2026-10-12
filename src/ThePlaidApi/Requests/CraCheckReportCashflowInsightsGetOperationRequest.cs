using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportCashflowInsightsGet operation.
/// </summary>
public sealed record CraCheckReportCashflowInsightsGetOperationRequest
{
    public required CraCheckReportCashflowInsightsGetRequest Body { get; init; }
}
