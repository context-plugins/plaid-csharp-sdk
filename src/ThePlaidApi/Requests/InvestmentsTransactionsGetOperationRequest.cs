using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the InvestmentsTransactionsGet operation.
/// </summary>
public sealed record InvestmentsTransactionsGetOperationRequest
{
    public required InvestmentsTransactionsGetRequest Body { get; init; }
}
