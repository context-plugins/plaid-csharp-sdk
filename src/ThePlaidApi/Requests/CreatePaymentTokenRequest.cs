using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreatePaymentToken operation.
/// </summary>
public sealed record CreatePaymentTokenRequest
{
    public required PaymentInitiationPaymentTokenCreateRequest Body { get; init; }
}
