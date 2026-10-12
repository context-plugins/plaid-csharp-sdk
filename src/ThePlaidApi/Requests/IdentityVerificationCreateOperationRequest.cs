using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityVerificationCreate operation.
/// </summary>
public sealed record IdentityVerificationCreateOperationRequest
{
    public required IdentityVerificationCreateRequest Body { get; init; }
}
