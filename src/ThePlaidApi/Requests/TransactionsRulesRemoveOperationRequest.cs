using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsRulesRemove operation.
/// </summary>
public sealed record TransactionsRulesRemoveOperationRequest
{
    public required TransactionsRulesRemoveRequest Body { get; init; }
}
