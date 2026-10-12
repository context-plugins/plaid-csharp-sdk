using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRefundCreate operation.
/// </summary>
public sealed record TransferRefundCreateOperationRequest
{
    public required TransferRefundCreateRequest Body { get; init; }
}
