using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Response object for /protect/event/send
/// </summary>
public record ProtectEventSendResponse
{
    /// <summary>
    /// The id of the recorded event.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; init; }

    /// <summary>
    /// Represents a calculated Trust Index Score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust_index")]
    public TrustIndex? TrustIndex { get; init; }

    /// <summary>
    /// Event fraud attributes as an arbitrary set of key-value pairs. The set of attributes returned varies by model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraud_attributes")]
    public object? FraudAttributes { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
