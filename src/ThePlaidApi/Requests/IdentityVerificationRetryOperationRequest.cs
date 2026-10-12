using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityVerificationRetry operation.
/// </summary>
public sealed record IdentityVerificationRetryOperationRequest
{
    public required IdentityVerificationRetryRequest Body { get; init; }
}
