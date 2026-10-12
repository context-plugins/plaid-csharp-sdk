using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationPaymentList operation.
/// </summary>
public sealed record PaymentInitiationPaymentListOperationRequest
{
    public required PaymentInitiationPaymentListRequest Body { get; init; }
}
