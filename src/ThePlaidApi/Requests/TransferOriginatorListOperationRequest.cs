using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferOriginatorList operation.
/// </summary>
public sealed record TransferOriginatorListOperationRequest
{
    public required TransferOriginatorListRequest Body { get; init; }
}
