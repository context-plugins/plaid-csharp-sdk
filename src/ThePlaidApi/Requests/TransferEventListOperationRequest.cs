using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferEventList operation.
/// </summary>
public sealed record TransferEventListOperationRequest
{
    public required TransferEventListRequest Body { get; init; }
}
