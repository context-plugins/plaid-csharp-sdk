using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CashflowReportInsightsGet operation.
/// </summary>
public sealed record CashflowReportInsightsGetOperationRequest
{
    public required CashflowReportInsightsGetRequest Body { get; init; }
}
