using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the StatementsRefresh operation.
/// </summary>
public sealed record StatementsRefreshOperationRequest
{
    public required StatementsRefreshRequest Body { get; init; }
}
