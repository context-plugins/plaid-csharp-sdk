using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the OauthToken operation.
/// </summary>
public sealed record OauthTokenOperationRequest
{
    public required OAuthTokenRequest Body { get; init; }
}
