using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An event that occurred while the user was going through Link
/// </summary>
public record LinkEvent
{
    /// <summary>
    /// Event name
    /// </summary>
    [JsonPropertyName("event_name")]
    public required string EventName { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required string Timestamp { get; init; }

    /// <summary>
    /// UUID that can be used to deduplicate events
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; init; }

    /// <summary>
    /// Metadata about an event that occurred while the user was going through Link
    /// </summary>
    [JsonPropertyName("event_metadata")]
    public required LinkEventMetadata EventMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
