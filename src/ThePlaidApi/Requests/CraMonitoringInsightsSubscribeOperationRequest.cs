using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraMonitoringInsightsSubscribe operation.
/// </summary>
public sealed record CraMonitoringInsightsSubscribeOperationRequest
{
    public required CraMonitoringInsightsSubscribeRequest Body { get; init; }
}
