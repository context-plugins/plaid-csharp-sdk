using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserItemsRemove operation.
/// </summary>
public sealed record UserItemsRemoveOperationRequest
{
    public required UserItemsRemoveRequest Body { get; init; }
}
