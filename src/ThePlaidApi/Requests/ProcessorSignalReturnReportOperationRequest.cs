using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorSignalReturnReport operation.
/// </summary>
public sealed record ProcessorSignalReturnReportOperationRequest
{
    public required ProcessorSignalReturnReportRequest Body { get; init; }
}
