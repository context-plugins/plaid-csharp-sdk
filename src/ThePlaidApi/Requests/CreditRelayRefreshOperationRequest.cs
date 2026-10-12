using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditRelayRefresh operation.
/// </summary>
public sealed record CreditRelayRefreshOperationRequest
{
    public required CreditRelayRefreshRequest Body { get; init; }
}
