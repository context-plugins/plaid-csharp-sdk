using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankIncomeRefresh operation.
/// </summary>
public sealed record CreditBankIncomeRefreshOperationRequest
{
    public required CreditBankIncomeRefreshRequest Body { get; init; }
}
