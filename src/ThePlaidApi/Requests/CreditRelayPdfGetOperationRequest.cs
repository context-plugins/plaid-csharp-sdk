using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditRelayPdfGet operation.
/// </summary>
public sealed record CreditRelayPdfGetOperationRequest
{
    public required CreditRelayPdfGetRequest Body { get; init; }
}
