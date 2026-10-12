using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AccountsGet operation.
/// </summary>
public sealed record AccountsGetOperationRequest
{
    public required AccountsGetRequest Body { get; init; }
}
