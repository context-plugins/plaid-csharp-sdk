using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportPartnerInsightsGet operation.
/// </summary>
public sealed record CraCheckReportPartnerInsightsGetOperationRequest
{
    public required CraCheckReportPartnerInsightsGetRequest Body { get; init; }
}
