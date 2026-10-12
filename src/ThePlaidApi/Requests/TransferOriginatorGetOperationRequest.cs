using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferOriginatorGet operation.
/// </summary>
public sealed record TransferOriginatorGetOperationRequest
{
    public required TransferOriginatorGetRequest Body { get; init; }
}
