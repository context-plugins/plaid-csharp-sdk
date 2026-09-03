using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of an identity verification has been updated, which can be triggered via the dashboard or the API.
/// </summary>
public record IdentityVerificationStatusUpdatedWebhook
{
    /// <summary>
    /// <c>IDENTITY_VERIFICATION</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>STATUS_UPDATED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The ID of the associated Identity Verification attempt.
    /// </summary>
    [JsonPropertyName("identity_verification_id")]
    public required string IdentityVerificationId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
