using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferRefundGet operation.
/// </summary>
public sealed record TransferRefundGetOperationRequest
{
    public required TransferRefundGetRequest Body { get; init; }
}
