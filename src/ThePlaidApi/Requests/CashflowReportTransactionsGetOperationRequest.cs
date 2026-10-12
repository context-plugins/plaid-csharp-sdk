using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CashflowReportTransactionsGet operation.
/// </summary>
public sealed record CashflowReportTransactionsGetOperationRequest
{
    public required CashflowReportTransactionsGetRequest Body { get; init; }
}
