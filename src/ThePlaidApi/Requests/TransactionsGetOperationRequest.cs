using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsGet operation.
/// </summary>
public sealed record TransactionsGetOperationRequest
{
    public required TransactionsGetRequest Body { get; init; }
}
