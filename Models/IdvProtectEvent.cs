using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about a Protect event including Trust Index score and fraud attributes.
/// </summary>
public record IdvProtectEvent
{
    /// <summary>
    /// The event ID.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; init; }

    /// <summary>
    /// The timestamp of the event, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Represents a calculated Trust Index Score.
    /// </summary>
    [JsonPropertyName("trust_index")]
    public required TrustIndex? TrustIndex { get; init; }

    /// <summary>
    /// Event fraud attributes as an arbitrary set of key-value pairs. The set of attributes returned varies by model.
    /// </summary>
    [JsonPropertyName("fraud_attributes")]
    public required object? FraudAttributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
