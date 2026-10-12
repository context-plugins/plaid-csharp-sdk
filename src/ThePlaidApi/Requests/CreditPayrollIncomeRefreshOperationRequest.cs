using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditPayrollIncomeRefresh operation.
/// </summary>
public sealed record CreditPayrollIncomeRefreshOperationRequest
{
    public required CreditPayrollIncomeRefreshRequest Body { get; init; }
}
