using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorSignalEvaluate operation.
/// </summary>
public sealed record ProcessorSignalEvaluateOperationRequest
{
    public required ProcessorSignalEvaluateRequest Body { get; init; }
}
