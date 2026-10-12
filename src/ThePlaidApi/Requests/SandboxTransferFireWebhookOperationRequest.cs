using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransferFireWebhook operation.
/// </summary>
public sealed record SandboxTransferFireWebhookOperationRequest
{
    public required SandboxTransferFireWebhookRequest Body { get; init; }
}
