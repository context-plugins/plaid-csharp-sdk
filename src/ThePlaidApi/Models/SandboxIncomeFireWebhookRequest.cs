using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxIncomeFireWebhookRequest defines the request schema for <c>/sandbox/income/fire_webhook</c>
/// </summary>
public record SandboxIncomeFireWebhookRequest
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
    /// The URL to which the webhook should be sent.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string Webhook { get; init; }

    /// <summary>
    /// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/income/verification/paystubs/get</c> endpoint and check the document metadata to see which documents were successfully parsed.
    /// <para>
    /// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: A failure occurred when attempting to process the verification documentation.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_PENDING_APPROVAL</c>: (deprecated) The income verification has been sent to the user for review.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_status")]
    public VerificationStatus3? VerificationStatus { get; init; }

    /// <summary>
    /// The webhook codes that can be fired by this test endpoint.
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required SandboxIncomeWebhookFireRequestWebhookCode WebhookCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
