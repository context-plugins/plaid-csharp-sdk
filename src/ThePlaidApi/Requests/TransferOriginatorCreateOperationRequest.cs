using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferOriginatorCreate operation.
/// </summary>
public sealed record TransferOriginatorCreateOperationRequest
{
    public required TransferOriginatorCreateRequest Body { get; init; }
}
