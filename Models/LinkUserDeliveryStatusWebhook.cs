using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Webhook indicating that the status of the delivery of the Hosted Link session to a user
/// </summary>
public record LinkUserDeliveryStatusWebhook
{
    /// <summary>
    /// <c>LINK_DELIVERY</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>DELIVERY_STATUS</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The ID of the Hosted Link session.
    /// </summary>
    [JsonPropertyName("link_delivery_session_id")]
    public required string LinkDeliverySessionId { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required string Timestamp { get; init; }

    /// <summary>
    /// Information related to the delivery of the link session to users
    /// </summary>
    [JsonPropertyName("link_delivery_metadata")]
    public required LinkDeliveryMetadata LinkDeliveryMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
