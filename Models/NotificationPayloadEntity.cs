using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Custom key-value pairs payload for a notification
/// </summary>
public record NotificationPayloadEntity
{
    /// <summary>
    /// ID for the origination entity related to the notification
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Type of entity causing origination of a notification
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idType")]
    public NotificationPayloadIdType? IdType { get; init; }

    /// <summary>
    /// Details of consent or payment network identifier or other entity's revocation request or other lifecycle status change event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public FdxLifecycleEventEntity? Event { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
