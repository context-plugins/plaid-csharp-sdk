using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsRecurringGet operation.
/// </summary>
public sealed record TransactionsRecurringGetOperationRequest
{
    public required TransactionsRecurringGetRequest Body { get; init; }
}
