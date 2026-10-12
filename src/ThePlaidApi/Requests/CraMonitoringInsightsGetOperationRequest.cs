using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraMonitoringInsightsGet operation.
/// </summary>
public sealed record CraMonitoringInsightsGetOperationRequest
{
    public required CraMonitoringInsightsGetRequest Body { get; init; }
}
