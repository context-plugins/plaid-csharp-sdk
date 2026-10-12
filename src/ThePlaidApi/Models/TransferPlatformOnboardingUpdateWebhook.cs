using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of an onboarding originator has been updated. Call <c>/transfer/originator/get</c> to check the latest status
/// </summary>
public record TransferPlatformOnboardingUpdateWebhook
{
    /// <summary>
    /// <c>"TRANSFER"</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>"PLATFORM_ONBOARDING_UPDATE"</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The client ID of the originator
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string OriginatorClientId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
