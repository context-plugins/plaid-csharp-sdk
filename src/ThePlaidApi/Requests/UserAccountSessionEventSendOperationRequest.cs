using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserAccountSessionEventSend operation.
/// </summary>
public sealed record UserAccountSessionEventSendOperationRequest
{
    public required UserAccountSessionEventSendRequest Body { get; init; }
}
