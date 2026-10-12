using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityRefresh operation.
/// </summary>
public sealed record IdentityRefreshOperationRequest
{
    public required IdentityRefreshRequest Body { get; init; }
}
