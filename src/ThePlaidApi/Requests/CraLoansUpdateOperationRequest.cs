using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraLoansUpdate operation.
/// </summary>
public sealed record CraLoansUpdateOperationRequest
{
    public required CraLoansUpdateRequest Body { get; init; }
}
