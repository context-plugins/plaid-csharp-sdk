using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserItemsGet operation.
/// </summary>
public sealed record UserItemsGetOperationRequest
{
    public required UserItemsGetRequest Body { get; init; }
}
