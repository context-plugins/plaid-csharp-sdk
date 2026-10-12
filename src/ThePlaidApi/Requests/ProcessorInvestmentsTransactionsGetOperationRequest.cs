using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorInvestmentsTransactionsGet operation.
/// </summary>
public sealed record ProcessorInvestmentsTransactionsGetOperationRequest
{
    public required ProcessorInvestmentsTransactionsGetRequest Body { get; init; }
}
