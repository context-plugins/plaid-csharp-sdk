using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferPlatformPersonCreate operation.
/// </summary>
public sealed record TransferPlatformPersonCreateOperationRequest
{
    public required TransferPlatformPersonCreateRequest Body { get; init; }
}
