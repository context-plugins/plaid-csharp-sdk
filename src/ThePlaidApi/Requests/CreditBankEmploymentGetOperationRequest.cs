using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankEmploymentGet operation.
/// </summary>
public sealed record CreditBankEmploymentGetOperationRequest
{
    public required CreditBankEmploymentGetRequest Body { get; init; }
}
