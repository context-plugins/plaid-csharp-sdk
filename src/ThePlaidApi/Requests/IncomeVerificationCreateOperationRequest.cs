using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IncomeVerificationCreate operation.
/// </summary>
public sealed record IncomeVerificationCreateOperationRequest
{
    public required IncomeVerificationCreateRequest Body { get; init; }
}
