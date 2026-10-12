using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferPlatformOriginatorCreate operation.
/// </summary>
public sealed record TransferPlatformOriginatorCreateOperationRequest
{
    public required TransferPlatformOriginatorCreateRequest Body { get; init; }
}
