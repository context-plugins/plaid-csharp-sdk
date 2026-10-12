using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationConsentCreate operation.
/// </summary>
public sealed record PaymentInitiationConsentCreateOperationRequest
{
    public required PaymentInitiationConsentCreateRequest Body { get; init; }
}
