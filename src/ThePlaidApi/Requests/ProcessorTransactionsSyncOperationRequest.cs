using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTransactionsSync operation.
/// </summary>
public sealed record ProcessorTransactionsSyncOperationRequest
{
    public required ProcessorTransactionsSyncRequest Body { get; init; }
}
