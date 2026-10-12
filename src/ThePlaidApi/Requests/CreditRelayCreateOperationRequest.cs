using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditRelayCreate operation.
/// </summary>
public sealed record CreditRelayCreateOperationRequest
{
    public required CreditRelayCreateRequest Body { get; init; }
}
