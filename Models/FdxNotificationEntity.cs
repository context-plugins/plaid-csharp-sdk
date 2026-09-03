using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Provides the base fields of a notification. Clients will read the <c>type</c> property to determine the expected notification payload.
/// </summary>
public record FdxNotificationEntity
{
    /// <summary>
    /// Id of notification
    /// </summary>
    [JsonPropertyName("notificationId")]
    public required string NotificationId { get; init; }

    /// <summary>
    /// Type of Notification
    /// </summary>
    [JsonPropertyName("type")]
    public required NotificationType Type { get; init; }

    /// <summary>
    /// An optional initiator-defined event subtype code or description if the event type needs to be further categorized or described.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtype")]
    public string? Subtype { get; init; }

    /// <summary>
    /// ISO 8601 date-time in format 'YYYY-MM-DDThh:mm:ss.nnn[Z|[+|-]hh:mm]' according to <see href="https://datatracker.ietf.org/doc/html/rfc3339">IETF RFC3339</see>
    /// </summary>
    [JsonPropertyName("sentOn")]
    public required DateTimeOffset SentOn { get; init; }

    /// <summary>
    /// Category of Notification
    /// </summary>
    [JsonPropertyName("category")]
    public required NotificationCategory Category { get; init; }

    /// <summary>
    /// Severity level of notification
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public NotificationSeverity? Severity { get; init; }

    /// <summary>
    /// Priority of notification
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public NotificationPriority? Priority { get; init; }

    /// <summary>
    /// FDX Participant - an entity or person that is a part of a FDX API transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publisher")]
    public PartyEntity? Publisher { get; init; }

    /// <summary>
    /// FDX Participant - an entity or person that is a part of a FDX API transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriber")]
    public PartyEntity? Subscriber { get; init; }

    /// <summary>
    /// Custom key-value pairs payload for a notification
    /// </summary>
    [JsonPropertyName("notificationPayload")]
    public required NotificationPayloadEntity NotificationPayload { get; init; }

    /// <summary>
    /// REST application constraint (Hypermedia As The Engine Of Application State)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public HateoasLink? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
