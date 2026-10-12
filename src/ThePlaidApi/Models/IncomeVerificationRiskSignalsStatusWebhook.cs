using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when risk signals have been processed for documents uploaded via Document Income. It will typically take a minute or two for this webhook to fire after the end user has uploaded their documents in the Document Income flow. Once this webhook has fired, <c>/credit/payroll_income/risk_signals/get</c> may then be called to determine whether the documents were successfully processed and to retrieve risk data.
/// </summary>
public record IncomeVerificationRiskSignalsStatusWebhook
{
    /// <summary>
    /// <c>"INCOME"</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>INCOME_VERIFICATION_RISK_SIGNALS</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Item ID associated with the verification.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// <c>RISK_SIGNALS_PROCESSING_COMPLETE</c>: The income verification fraud detection processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/credit/payroll_income/risk_signals/get</c> endpoint to get all risk signal data.
    /// </summary>
    [JsonPropertyName("risk_signals_status")]
    public required string RiskSignalsStatus { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
