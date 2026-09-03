using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a change to the user's income is detected. To obtain refreshed Bank Income data, send the user through Link's update mode so they can confirm their income sources, or migrate to CRA Income Insights and call <c>/cra/check_report/create</c> for a backend refresh. To receive this webhook, subscribe in the <see href="https://dashboard.plaid.com/developers/webhooks">Dashboard</see>.
/// </summary>
public record BankIncomeRefreshUpdateWebhook
{
    /// <summary>
    /// <c>INCOME</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>BANK_INCOME_REFRESH_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>user_id</c> corresponding to the user the webhook has fired for.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
