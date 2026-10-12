using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorSignalPrepare operation.
/// </summary>
public sealed record ProcessorSignalPrepareOperationRequest
{
    public required ProcessorSignalPrepareRequest Body { get; init; }
}
