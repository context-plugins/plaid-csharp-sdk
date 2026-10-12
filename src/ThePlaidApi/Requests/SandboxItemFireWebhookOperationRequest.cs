using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxItemFireWebhook operation.
/// </summary>
public sealed record SandboxItemFireWebhookOperationRequest
{
    public required SandboxItemFireWebhookRequest Body { get; init; }
}
