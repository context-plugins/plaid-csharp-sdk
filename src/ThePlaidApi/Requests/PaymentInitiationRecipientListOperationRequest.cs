using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationRecipientList operation.
/// </summary>
public sealed record PaymentInitiationRecipientListOperationRequest
{
    public required PaymentInitiationRecipientListRequest Body { get; init; }
}
