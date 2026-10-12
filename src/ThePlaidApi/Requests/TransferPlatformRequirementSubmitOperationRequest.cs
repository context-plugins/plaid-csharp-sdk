using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferPlatformRequirementSubmit operation.
/// </summary>
public sealed record TransferPlatformRequirementSubmitOperationRequest
{
    public required TransferPlatformRequirementSubmitRequest Body { get; init; }
}
