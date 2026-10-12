using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRecurringList operation.
/// </summary>
public sealed record TransferRecurringListOperationRequest
{
    public required TransferRecurringListRequest Body { get; init; }
}
