using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the StatementsList operation.
/// </summary>
public sealed record StatementsListOperationRequest
{
    public required StatementsListRequest Body { get; init; }
}
