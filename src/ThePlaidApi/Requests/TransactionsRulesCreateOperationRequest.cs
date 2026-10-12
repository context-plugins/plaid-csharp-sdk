using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsRulesCreate operation.
/// </summary>
public sealed record TransactionsRulesCreateOperationRequest
{
    public required TransactionsRulesCreateRequest Body { get; init; }
}
