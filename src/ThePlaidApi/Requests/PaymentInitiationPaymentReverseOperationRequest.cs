using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationPaymentReverse operation.
/// </summary>
public sealed record PaymentInitiationPaymentReverseOperationRequest
{
    public required PaymentInitiationPaymentReverseRequest Body { get; init; }
}
