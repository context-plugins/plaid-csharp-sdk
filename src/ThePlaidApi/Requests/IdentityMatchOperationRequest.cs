using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityMatch operation.
/// </summary>
public sealed record IdentityMatchOperationRequest
{
    public required IdentityMatchRequest Body { get; init; }
}
