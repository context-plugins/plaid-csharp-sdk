using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditPayrollIncomePrecheck operation.
/// </summary>
public sealed record CreditPayrollIncomePrecheckOperationRequest
{
    public required CreditPayrollIncomePrecheckRequest Body { get; init; }
}
