using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferCancel operation.
/// </summary>
public sealed record TransferCancelOperationRequest
{
    public required TransferCancelRequest Body { get; init; }
}
