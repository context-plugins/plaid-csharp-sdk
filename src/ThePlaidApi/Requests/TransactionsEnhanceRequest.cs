using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsEnhance operation.
/// </summary>
public sealed record TransactionsEnhanceRequest
{
    public required TransactionsEnhanceGetRequest Body { get; init; }
}
