using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SignalReturnReport operation.
/// </summary>
public sealed record SignalReturnReportOperationRequest
{
    public required SignalReturnReportRequest Body { get; init; }
}
