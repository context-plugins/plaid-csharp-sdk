using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserAccountSessionGet operation.
/// </summary>
public sealed record UserAccountSessionGetOperationRequest
{
    public required UserAccountSessionGetRequest Body { get; init; }
}
