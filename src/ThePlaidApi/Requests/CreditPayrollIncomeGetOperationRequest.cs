using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditPayrollIncomeGet operation.
/// </summary>
public sealed record CreditPayrollIncomeGetOperationRequest
{
    public required CreditPayrollIncomeGetRequest Body { get; init; }
}
