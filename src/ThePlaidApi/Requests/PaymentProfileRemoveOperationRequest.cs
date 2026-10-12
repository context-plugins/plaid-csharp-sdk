using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PaymentProfileRemove operation.
/// </summary>
public sealed record PaymentProfileRemoveOperationRequest
{
    public required PaymentProfileRemoveRequest Body { get; init; }
}
