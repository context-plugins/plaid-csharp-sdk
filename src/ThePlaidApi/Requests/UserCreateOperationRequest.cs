using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserCreate operation.
/// </summary>
public sealed record UserCreateOperationRequest
{
    /// <summary>
    /// The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.
    /// </summary>
    public bool PlaidNewUserApiEnabled { get; init; } = false;

    public required UserCreateRequest Body { get; init; }
}
