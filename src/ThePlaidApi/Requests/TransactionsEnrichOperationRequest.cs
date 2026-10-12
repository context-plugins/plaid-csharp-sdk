using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsEnrich operation.
/// </summary>
public sealed record TransactionsEnrichOperationRequest
{
    public required TransactionsEnrichRequest Body { get; init; }
}
