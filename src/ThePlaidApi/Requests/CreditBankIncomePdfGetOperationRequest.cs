using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankIncomePdfGet operation.
/// </summary>
public sealed record CreditBankIncomePdfGetOperationRequest
{
    public required CreditBankIncomePdfGetRequest Body { get; init; }
}
