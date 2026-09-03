using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when an Item is expected to be disconnected. The webhook will currently be fired 7 days before the existing Item is scheduled for disconnection. This can be resolved by having the user go through Link's <see href="https://plaid.com/docs/link/update-mode">update mode</see>. Currently, this webhook is fired only for US or Canadian institutions; in the UK or EU, you should continue to listen for the <see href="https://plaid.com/docs/api/items/#pending_expiration"><c>PENDING_EXPIRATION</c></see> webhook instead.
/// </summary>
public record PendingDisconnectWebhook
{
    /// <summary>
    /// <c>ITEM</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>PENDING_DISCONNECT</c>
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
    /// Reason why the Item is about to be disconnected.
    /// <c>INSTITUTION_MIGRATION</c>: The institution is moving to API or to a different integration. For example, this can occur when an institution moves from a non-OAuth integration to an OAuth integration.
    /// <c>INSTITUTION_TOKEN_EXPIRATION</c>: The consent on an Item associated with a US or CA institution is about to expire.
    /// </summary>
    [JsonPropertyName("reason")]
    public required PendingDisconnectWebhookReason Reason { get; init; }

    /// <summary>
    /// The date and time at which the Item is scheduled to disconnect, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("disconnect_time")]
    public required DateTimeOffset DisconnectTime { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
