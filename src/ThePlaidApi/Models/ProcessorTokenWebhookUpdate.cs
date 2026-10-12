using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// This webhook is only sent to <see href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</see>.
/// <para>
/// Fired when a processor updates the webhook URL for a processor token via <c>/processor/token/webhook/update</c>.
/// </para>
/// </summary>
public record ProcessorTokenWebhookUpdate
{
    /// <summary>
    /// <c>PROCESSOR_TOKEN</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>WEBHOOK_UPDATE_ACKNOWLEDGED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The ID of the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The new webhook URL.
    /// </summary>
    [JsonPropertyName("new_webhook_url")]
    public required string NewWebhookUrl { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
