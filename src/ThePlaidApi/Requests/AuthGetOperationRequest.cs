using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AuthGet operation.
/// </summary>
public sealed record AuthGetOperationRequest
{
    public required AuthGetRequest Body { get; init; }
}
