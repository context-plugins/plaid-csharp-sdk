using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProtectEventSend operation.
/// </summary>
public sealed record ProtectEventSendOperationRequest
{
    public required ProtectEventSendRequest Body { get; init; }
}
