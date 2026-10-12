using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserIdentityRemove operation.
/// </summary>
public sealed record UserIdentityRemoveOperationRequest
{
    /// <summary>
    /// The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.
    /// </summary>
    public bool PlaidNewUserApiEnabled { get; init; } = false;

    public required UserIdentityRemoveRequest Body { get; init; }
}
