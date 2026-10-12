using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportIncomeInsightsGet operation.
/// </summary>
public sealed record CraCheckReportIncomeInsightsGetOperationRequest
{
    public required CraCheckReportIncomeInsightsGetRequest Body { get; init; }
}
