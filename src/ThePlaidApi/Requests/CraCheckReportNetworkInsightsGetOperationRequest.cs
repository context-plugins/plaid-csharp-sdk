using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportNetworkInsightsGet operation.
/// </summary>
public sealed record CraCheckReportNetworkInsightsGetOperationRequest
{
    public required CraCheckReportNetworkInsightsGetRequest Body { get; init; }
}
