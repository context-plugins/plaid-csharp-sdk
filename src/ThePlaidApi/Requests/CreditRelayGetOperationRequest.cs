using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditRelayGet operation.
/// </summary>
public sealed record CreditRelayGetOperationRequest
{
    public required CreditRelayGetRequest Body { get; init; }
}
