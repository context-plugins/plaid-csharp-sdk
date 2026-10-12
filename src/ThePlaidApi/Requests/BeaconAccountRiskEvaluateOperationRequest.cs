using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconAccountRiskEvaluate operation.
/// </summary>
public sealed record BeaconAccountRiskEvaluateOperationRequest
{
    public required BeaconAccountRiskEvaluateRequest Body { get; init; }
}
