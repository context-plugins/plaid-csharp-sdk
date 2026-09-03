using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxBankIncomeFireWebhookRequest defines the request schema for <c>/sandbox/bank_income/fire_webhook</c>
/// </summary>
public record SandboxBankIncomeFireWebhookRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The URL to which the webhook should be sent. If provided, this will override the URL set in the dashboard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_override")]
    public string? WebhookOverride { get; init; }

    /// <summary>
    /// The webhook codes this endpoint can be used to test
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required SandboxBankIncomeWebhookFireRequestWebhookCode WebhookCode { get; init; }

    /// <summary>
    /// Optional fields which will be populated in the simulated webhook
    /// </summary>
    [JsonPropertyName("webhook_fields")]
    public required SandboxBankIncomeWebhookFireRequestWebhookFields WebhookFields { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
