using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationConsentGet operation.
/// </summary>
public sealed record PaymentInitiationConsentGetOperationRequest
{
    public required PaymentInitiationConsentGetRequest Body { get; init; }
}
