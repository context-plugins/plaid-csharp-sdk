using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information related to the delivery of the link session to users
/// </summary>
public record LinkDeliveryMetadata
{
    /// <summary>
    /// The communication method used to deliver the Hosted Link session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("communication_method")]
    public LinkDeliveryWebhookCommunicationMethod? CommunicationMethod { get; init; }

    /// <summary>
    /// The status of the delivery of the Hosted Link to the user
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery_status")]
    public LinkDeliveryWebhookDeliveryStatus? DeliveryStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
