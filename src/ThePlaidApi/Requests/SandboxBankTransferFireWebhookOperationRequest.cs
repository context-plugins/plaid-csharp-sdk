using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxBankTransferFireWebhook operation.
/// </summary>
public sealed record SandboxBankTransferFireWebhookOperationRequest
{
    public required SandboxBankTransferFireWebhookRequest Body { get; init; }
}
