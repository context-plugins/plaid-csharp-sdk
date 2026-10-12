using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// For each user's Item enabled for Cash Flow Updates, this webhook will fire between one and four times a day with information on the status of the update. This webhook will not fire immediately upon enrollment in Cash Flow Updates. Upon receiving the webhook, call <c>/cra/monitoring_insights/get</c> to retrieve the updated insights. At approximately the same time as the <c>INSIGHTS_UPDATED</c> webhook, any event-driven <c>CASH_FLOW_UPDATES</c> webhooks (e.g. <c>LOW_BALANCE_DETECTED</c>, <c>LARGE_DEPOSIT_DETECTED</c>) that were triggered by the update will also fire. This webhook has been replaced by the <c>CASH_FLOW_INSIGHTS_UPDATED</c> webhook for all customers who began using Plaid Check on or after December 10, 2025.
/// </summary>
public record CashFlowUpdatesInsightsWebhook
{
    /// <summary>
    /// <c>CASH_FLOW_UPDATES</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>INSIGHTS_UPDATED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// Enum for the status of the insights
    /// </summary>
    [JsonPropertyName("status")]
    public required MonitoringInsightsStatus Status { get; init; }

    /// <summary>
    /// The <c>user_id</c> that the report is associated with
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
