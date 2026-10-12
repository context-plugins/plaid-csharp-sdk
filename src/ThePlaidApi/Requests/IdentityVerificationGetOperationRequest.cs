using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityVerificationGet operation.
/// </summary>
public sealed record IdentityVerificationGetOperationRequest
{
    public required IdentityVerificationGetRequest Body { get; init; }
}
