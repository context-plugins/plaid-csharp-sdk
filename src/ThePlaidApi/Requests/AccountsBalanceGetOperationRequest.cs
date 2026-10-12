using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AccountsBalanceGet operation.
/// </summary>
public sealed record AccountsBalanceGetOperationRequest
{
    public required AccountsBalanceGetRequest Body { get; init; }
}
