using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationPaymentCreate operation.
/// </summary>
public sealed record PaymentInitiationPaymentCreateOperationRequest
{
    public required PaymentInitiationPaymentCreateRequest Body { get; init; }
}
