using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a user successfully adds a Plaid Item during a Link session when using Hosted Link or Multi-Item Link sessions. Contains the public token for the Item.
/// </summary>
public record ItemAddResultWebhook
{
    /// <summary>
    /// <c>LINK</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>ITEM_ADD_RESULT</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The identifier for the Link session.
    /// </summary>
    [JsonPropertyName("link_session_id")]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// The <c>link_token</c> used to create the Link session.
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// The <c>public_token</c> corresponding to the Item that was added.
    /// </summary>
    [JsonPropertyName("public_token")]
    public required string PublicToken { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
