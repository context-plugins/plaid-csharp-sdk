using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraLoansApplicationsRegister operation.
/// </summary>
public sealed record CraLoansApplicationsRegisterOperationRequest
{
    public required CraLoansApplicationsRegisterRequest Body { get; init; }
}
