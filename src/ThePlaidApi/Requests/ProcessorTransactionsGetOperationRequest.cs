using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTransactionsGet operation.
/// </summary>
public sealed record ProcessorTransactionsGetOperationRequest
{
    public required ProcessorTransactionsGetRequest Body { get; init; }
}
