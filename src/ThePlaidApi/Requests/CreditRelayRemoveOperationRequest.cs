using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditRelayRemove operation.
/// </summary>
public sealed record CreditRelayRemoveOperationRequest
{
    public required CreditRelayRemoveRequest Body { get; init; }
}
