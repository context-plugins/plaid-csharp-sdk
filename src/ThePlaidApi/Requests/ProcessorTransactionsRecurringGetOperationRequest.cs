using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTransactionsRecurringGet operation.
/// </summary>
public sealed record ProcessorTransactionsRecurringGetOperationRequest
{
    public required ProcessorTransactionsRecurringGetRequest Body { get; init; }
}
