using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentProfileCreate operation.
/// </summary>
public sealed record PaymentProfileCreateOperationRequest
{
    public required PaymentProfileCreateRequest Body { get; init; }
}
