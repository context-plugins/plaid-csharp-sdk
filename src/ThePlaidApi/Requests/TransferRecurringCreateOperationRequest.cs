using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRecurringCreate operation.
/// </summary>
public sealed record TransferRecurringCreateOperationRequest
{
    public required TransferRecurringCreateRequest Body { get; init; }
}
