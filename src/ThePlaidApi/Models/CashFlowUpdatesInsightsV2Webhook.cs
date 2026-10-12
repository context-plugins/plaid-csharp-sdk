using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// For each item on an enabled user, this webhook will fire up to four times a day with status information. This webhook will not fire immediately upon enrollment in Cash Flow Updates. The payload may contain an <c>insights</c> array with insights that have been detected, if any (e.g. <c>LOW_BALANCE_DETECTED</c>, <c>LARGE_DEPOSIT_DETECTED</c>). Upon receiving the webhook, call <c>/cra/monitoring_insights/get</c> to retrieve the updated insights.
/// </summary>
public record CashFlowUpdatesInsightsV2Webhook
{
    /// <summary>
    /// <c>CASH_FLOW_UPDATES</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>CASH_FLOW_INSIGHTS_UPDATED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// Enum for the status of the insights
    /// </summary>
    [JsonPropertyName("status")]
    public required MonitoringInsightsStatus Status { get; init; }

    /// <summary>
    /// The <c>user_id</c> associated with the user whose data is being requested. This is received by calling <c>/user/create</c>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Array containing the insights detected within the generated report, if any. Possible values include:
    ///   <c>LARGE_DEPOSIT_DETECTED</c>: signaling a deposit over $5,000
    ///   <c>LOW_BALANCE_DETECTED</c>: signaling a balance below $100
    ///   <c>NEW_LOAN_PAYMENT_DETECTED</c>: signaling a new loan payment
    ///   <c>NSF_OVERDRAFT_DETECTED</c>: signaling an NSF overdraft
    /// </summary>
    [JsonPropertyName("insights")]
    public required IReadOnlyList<CashFlowInsight> Insights { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
