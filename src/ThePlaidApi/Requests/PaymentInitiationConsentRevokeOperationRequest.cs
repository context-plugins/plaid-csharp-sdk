using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationConsentRevoke operation.
/// </summary>
public sealed record PaymentInitiationConsentRevokeOperationRequest
{
    public required PaymentInitiationConsentRevokeRequest Body { get; init; }
}
