using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The webhook of type <c>LIABILITIES</c> and code <c>DEFAULT_UPDATE</c> will be fired when new or updated liabilities have been detected on a liabilities item.
/// </summary>
public record LiabilitiesDefaultUpdateWebhook
{
    /// <summary>
    /// <c>LIABILITIES</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>DEFAULT_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
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
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error? Error { get; init; }

    /// <summary>
    /// An array of <c>account_id</c>'s for accounts that contain new liabilities.'
    /// </summary>
    [JsonPropertyName("account_ids_with_new_liabilities")]
    public required IReadOnlyList<string> AccountIdsWithNewLiabilities { get; init; }

    /// <summary>
    /// An object with keys of <c>account_id</c>'s that are mapped to their respective liabilities fields that changed.
    /// <para>
    /// Example: <c>{ "XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58": ["past_amount_due"] }</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("account_ids_with_updated_liabilities")]
    public required IReadOnlyDictionary<string, object> AccountIdsWithUpdatedLiabilities { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
