using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SignalPrepare operation.
/// </summary>
public sealed record SignalPrepareOperationRequest
{
    public required SignalPrepareRequest Body { get; init; }
}
