using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserItemsAssociate operation.
/// </summary>
public sealed record UserItemsAssociateOperationRequest
{
    public required UserItemsAssociateRequest Body { get; init; }
}
