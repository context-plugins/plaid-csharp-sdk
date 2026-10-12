using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemPublicTokenExchange operation.
/// </summary>
public sealed record ItemPublicTokenExchangeOperationRequest
{
    public required ItemPublicTokenExchangeRequest Body { get; init; }
}
