using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraLoansUnregister operation.
/// </summary>
public sealed record CraLoansUnregisterOperationRequest
{
    public required CraLoansUnregisterRequest Body { get; init; }
}
