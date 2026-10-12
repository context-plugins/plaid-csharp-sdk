using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserThirdPartyTokenRemove operation.
/// </summary>
public sealed record UserThirdPartyTokenRemoveOperationRequest
{
    public required UserThirdPartyTokenRemoveRequest Body { get; init; }
}
