using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditPayrollIncomeParsingConfigUpdate operation.
/// </summary>
public sealed record CreditPayrollIncomeParsingConfigUpdateOperationRequest
{
    public required CreditPayrollIncomeParsingConfigUpdateRequest Body { get; init; }
}
