using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsSync operation.
/// </summary>
public sealed record TransactionsSyncOperationRequest
{
    public required TransactionsSyncRequest Body { get; init; }
}
