using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankIncomeGet operation.
/// </summary>
public sealed record CreditBankIncomeGetOperationRequest
{
    public required CreditBankIncomeGetRequest Body { get; init; }
}
