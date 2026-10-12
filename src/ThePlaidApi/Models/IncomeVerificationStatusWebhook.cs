using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of an income verification instance has changed. This webhook is fired for both the Document and Payroll Income flows, but not the Bank Income flow. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.
/// </summary>
public record IncomeVerificationStatusWebhook
{
    /// <summary>
    /// <c>"INCOME"</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>INCOME_VERIFICATION</c>
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
    /// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>:  The income verification processing has completed. This indicates that the documents have been parsed successfully or that the documents were not parsable. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/credit/payroll_income/get</c> endpoint and check the document metadata to see which documents were successfully parsed.
    /// <para>
    /// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: An unexpected internal error occurred when attempting to process the verification documentation.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_PENDING_APPROVAL</c>: (deprecated) The income verification has been sent to the user for review.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_status")]
    public required string VerificationStatus { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
