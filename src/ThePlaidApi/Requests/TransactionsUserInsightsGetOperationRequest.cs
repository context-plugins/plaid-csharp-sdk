using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransactionsUserInsightsGet operation.
/// </summary>
public sealed record TransactionsUserInsightsGetOperationRequest
{
    public required TransactionsUserInsightsGetRequest Body { get; init; }
}
