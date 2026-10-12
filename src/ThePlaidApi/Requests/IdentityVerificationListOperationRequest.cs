using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityVerificationList operation.
/// </summary>
public sealed record IdentityVerificationListOperationRequest
{
    public required IdentityVerificationListRequest Body { get; init; }
}
