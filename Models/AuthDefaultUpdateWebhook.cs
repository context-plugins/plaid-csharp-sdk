using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Plaid will trigger a <c>DEFAULT_UPDATE</c> webhook for Items that undergo a change in Auth data. This is generally caused by data partners notifying Plaid of a change in their account numbering system or to their routing numbers. To avoid returned transactions, customers that receive a <c>DEFAULT_UPDATE</c> webhook with the <c>account_ids_with_updated_auth</c> object populated should immediately discontinue all usages of existing Auth data for those accounts and call <c>/auth/get</c> or <c>/processor/auth/get</c> to obtain updated account and routing numbers.
/// </summary>
public record AuthDefaultUpdateWebhook
{
    /// <summary>
    /// <c>AUTH</c>
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
    /// An array of <c>account_id</c>'s for accounts that contain new auth.
    /// </summary>
    [JsonPropertyName("account_ids_with_new_auth")]
    public required IReadOnlyList<string> AccountIdsWithNewAuth { get; init; }

    /// <summary>
    /// An object with keys of <c>account_id</c>'s that are mapped to their respective auth attributes that changed. <c>ACCOUNT_NUMBER</c> and <c>ROUTING_NUMBER</c> are the two potential values that can be flagged as updated.
    /// <para>
    /// Example: <c>{ "XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58": ["ACCOUNT_NUMBER"] }</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("account_ids_with_updated_auth")]
    public required IReadOnlyDictionary<string, object> AccountIdsWithUpdatedAuth { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error? Error { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
