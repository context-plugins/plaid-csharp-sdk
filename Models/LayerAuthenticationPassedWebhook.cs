using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Indicates that Plaid's authentication process has completed for a user and that Plaid has verified that the user owns their phone number. If you receive this webhook, you should skip your own OTP phone number verification flow for the user, even if the user does not complete the entire Link flow. If the user doesn't complete the full Link flow (as verified by your being able to successfully call <c>/user_account/session/get</c> using the <c>public_token</c> from the <c>onSuccess</c> callback) it is recommended that you implement <see href="https://plaid.com/docs/api/webhooks/webhook-verification/">webhook verification</see> or another technique to avoid webhook spoofing attacks.
/// </summary>
public record LayerAuthenticationPassedWebhook
{
    /// <summary>
    /// <c>LAYER</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>LAYER_AUTHENTICATION_PASSED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    /// <summary>
    /// An identifier for the Link session these events occurred in
    /// </summary>
    [JsonPropertyName("link_session_id")]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// The Link token used to create the Link session these events are from
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
