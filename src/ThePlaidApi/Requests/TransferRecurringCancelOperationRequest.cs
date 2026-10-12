using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRecurringCancel operation.
/// </summary>
public sealed record TransferRecurringCancelOperationRequest
{
    public required TransferRecurringCancelRequest Body { get; init; }
}
