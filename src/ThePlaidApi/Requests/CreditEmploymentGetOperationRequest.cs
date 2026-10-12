using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditEmploymentGet operation.
/// </summary>
public sealed record CreditEmploymentGetOperationRequest
{
    public required CreditEmploymentGetRequest Body { get; init; }
}
