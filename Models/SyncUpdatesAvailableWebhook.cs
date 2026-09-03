using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when an Item's transactions change. This can be due to any event resulting in new changes, such as an initial 30-day transactions fetch upon the initialization of an Item with transactions, the backfill of historical transactions that occurs shortly after, or when changes are populated from a regularly-scheduled transactions update job. It is recommended to listen for the <c>SYNC_UPDATES_AVAILABLE</c> webhook when using the <c>/transactions/sync</c> endpoint. Note that when using <c>/transactions/sync</c> the older webhooks <c>INITIAL_UPDATE</c>, <c>HISTORICAL_UPDATE</c>, <c>DEFAULT_UPDATE</c>, and <c>TRANSACTIONS_REMOVED</c>, which are intended for use with <c>/transactions/get</c>, will also continue to be sent in order to maintain backwards compatibility. It is not necessary to listen for and respond to those webhooks when using <c>/transactions/sync</c>.
/// <para>
/// After receipt of this webhook, the new changes can be fetched for the Item from <c>/transactions/sync</c>.
/// </para>
/// <para>
/// Note that to receive this webhook for an Item, <c>/transactions/sync</c> must have been called at least once on that Item. This means that, unlike the <c>INITIAL_UPDATE</c> and <c>HISTORICAL_UPDATE</c> webhooks, it will not fire immediately upon Item creation. If <c>/transactions/sync</c> is called on an Item that was *not* initialized with Transactions, the webhook will fire twice: once the first 30 days of transactions data has been fetched, and a second time when all available historical transactions data has been fetched.
/// </para>
/// <para>
/// This webhook will fire in the Sandbox environment as it would in Production. It can also be manually triggered in Sandbox by calling <c>/sandbox/item/fire_webhook</c>.
/// </para>
/// </summary>
public record SyncUpdatesAvailableWebhook
{
    /// <summary>
    /// <c>TRANSACTIONS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>SYNC_UPDATES_AVAILABLE</c>
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
    /// Indicates if initial pull information (most recent 30 days of transaction history) is available.
    /// </summary>
    [JsonPropertyName("initial_update_complete")]
    public required bool InitialUpdateComplete { get; init; }

    /// <summary>
    /// Indicates if historical pull information (maximum transaction history requested, up to 2 years) is available.
    /// </summary>
    [JsonPropertyName("historical_update_complete")]
    public required bool HistoricalUpdateComplete { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
