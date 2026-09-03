using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// For each user's Item enabled for Cash Flow Updates, this webhook will fire when an update detects a new loan payment. Upon receiving the webhook, call <c>/cra/monitoring_insights/get</c> to retrieve the updated insights.
/// </summary>
public record CashFlowUpdatesNewLoanPaymentWebhook
{
    /// <summary>
    /// <c>CASH_FLOW_UPDATES</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>NEW_LOAN_PAYMENT_DETECTED</c>
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
