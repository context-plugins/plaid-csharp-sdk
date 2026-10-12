using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTransactionsRefresh operation.
/// </summary>
public sealed record ProcessorTransactionsRefreshOperationRequest
{
    public required ProcessorTransactionsRefreshRequest Body { get; init; }
}
