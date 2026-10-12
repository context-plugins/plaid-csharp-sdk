using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the EmploymentVerificationGet operation.
/// </summary>
public sealed record EmploymentVerificationGetOperationRequest
{
    public required EmploymentVerificationGetRequest Body { get; init; }
}
