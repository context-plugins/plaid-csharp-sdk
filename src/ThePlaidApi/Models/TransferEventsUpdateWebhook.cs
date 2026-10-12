using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when new transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/transfer/event/sync</c>. If multiple transfer events occur within a single minute, only one webhook will be fired, so a single webhook instance may correspond to multiple transfer events.
/// </summary>
public record TransferEventsUpdateWebhook
{
    /// <summary>
    /// <c>TRANSFER</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>TRANSFER_EVENTS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
