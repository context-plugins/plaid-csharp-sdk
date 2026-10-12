using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankIncomeWebhookUpdate operation.
/// </summary>
public sealed record CreditBankIncomeWebhookUpdateOperationRequest
{
    public required CreditBankIncomeWebhookUpdateRequest Body { get; init; }
}
