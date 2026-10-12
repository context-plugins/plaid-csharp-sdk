using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditPayrollIncomeRiskSignalsGet operation.
/// </summary>
public sealed record CreditPayrollIncomeRiskSignalsGetOperationRequest
{
    public required CreditPayrollIncomeRiskSignalsGetRequest Body { get; init; }
}
