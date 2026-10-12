using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRecurringGet operation.
/// </summary>
public sealed record TransferRecurringGetOperationRequest
{
    public required TransferRecurringGetRequest Body { get; init; }
}
