using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the OauthRevoke operation.
/// </summary>
public sealed record OauthRevokeOperationRequest
{
    public required OAuthRevokeRequest Body { get; init; }
}
