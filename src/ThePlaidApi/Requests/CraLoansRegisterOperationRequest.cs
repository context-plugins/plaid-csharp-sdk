using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraLoansRegister operation.
/// </summary>
public sealed record CraLoansRegisterOperationRequest
{
    public required CraLoansRegisterRequest Body { get; init; }
}
