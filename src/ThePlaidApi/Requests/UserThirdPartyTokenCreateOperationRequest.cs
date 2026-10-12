using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserThirdPartyTokenCreate operation.
/// </summary>
public sealed record UserThirdPartyTokenCreateOperationRequest
{
    public required UserThirdPartyTokenCreateRequest Body { get; init; }
}
