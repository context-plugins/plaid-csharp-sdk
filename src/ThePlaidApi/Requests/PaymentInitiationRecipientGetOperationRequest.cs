using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentInitiationRecipientGet operation.
/// </summary>
public sealed record PaymentInitiationRecipientGetOperationRequest
{
    public required PaymentInitiationRecipientGetRequest Body { get; init; }
}
