using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationConsentPaymentExecute operation.
/// </summary>
public sealed record PaymentInitiationConsentPaymentExecuteOperationRequest
{
    public required PaymentInitiationConsentPaymentExecuteRequest Body { get; init; }
}
