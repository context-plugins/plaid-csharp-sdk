using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The <c>USER_PERMISSION_REVOKED</c> webhook may be fired when an end user has revoked the permission that they previously granted to access an Item. If the end user revoked their permissions through Plaid (such as via the Plaid Portal or by contacting Plaid support), the webhook will fire. If the end user revoked their permissions directly through the institution, this webhook may not always fire, since some institutions' consent portals do not trigger this webhook. To attempt to restore the Item, it can be sent through <see href="https://plaid.com/docs/link/update-mode">update mode</see>. Depending on the exact process the end user used to revoke permissions, it may not be possible to launch update mode for the Item. If you encounter an error when attempting to create a Link token for update mode on an Item with revoked permissions, create a fresh Link token for the user.
/// <para>
/// Note that when working with tokenized account numbers with Auth or Transfer, the account number provided by Plaid will no longer work for creating transfers once user permission has been revoked, except for US Bank Items.
/// </para>
/// </summary>
public record UserPermissionRevokedWebhook
{
    /// <summary>
    /// <c>ITEM</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>USER_PERMISSION_REVOKED</c>
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
