using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentProfileGet operation.
/// </summary>
public sealed record PaymentProfileGetOperationRequest
{
    public required PaymentProfileGetRequest Body { get; init; }
}
