using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraMonitoringInsightsUnsubscribe operation.
/// </summary>
public sealed record CraMonitoringInsightsUnsubscribeOperationRequest
{
    public required CraMonitoringInsightsUnsubscribeRequest Body { get; init; }
}
