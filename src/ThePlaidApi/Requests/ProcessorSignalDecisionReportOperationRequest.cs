using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorSignalDecisionReport operation.
/// </summary>
public sealed record ProcessorSignalDecisionReportOperationRequest
{
    public required ProcessorSignalDecisionReportRequest Body { get; init; }
}
