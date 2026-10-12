using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxBankIncomeFireWebhook operation.
/// </summary>
public sealed record SandboxBankIncomeFireWebhookOperationRequest
{
    public required SandboxBankIncomeFireWebhookRequest Body { get; init; }
}
