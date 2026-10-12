using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the OauthIntrospect operation.
/// </summary>
public sealed record OauthIntrospectOperationRequest
{
    public required OAuthIntrospectRequest Body { get; init; }
}
