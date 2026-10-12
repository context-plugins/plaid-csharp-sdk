using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsRulesList operation.
/// </summary>
public sealed record TransactionsRulesListOperationRequest
{
    public required TransactionsRulesListRequest Body { get; init; }
}
