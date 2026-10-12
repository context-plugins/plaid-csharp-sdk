using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserTransactionsRefresh operation.
/// </summary>
public sealed record UserTransactionsRefreshOperationRequest
{
    public required UserTransactionsRefreshRequest Body { get; init; }
}
