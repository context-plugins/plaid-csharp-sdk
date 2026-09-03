using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the incident event.
/// </summary>
public record ProtectIncidentEventResponse
{
    /// <summary>
    /// A globally unique identifier representing a Protect event that may be associated with this incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("protect_event_id")]
    public string? ProtectEventId { get; init; }

    /// <summary>
    /// A unique identifier for a Link session that may be associated with this incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// A unique identifier for an Identity Verification session that may be associated with this incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idv_session_id")]
    public string? IdvSessionId { get; init; }

    /// <summary>
    /// The unique ID used to refer to a Signal transaction evaluation that may be associated with this incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signal_client_transaction_id")]
    public string? SignalClientTransactionId { get; init; }

    /// <summary>
    /// A unique ID representing the incident in your system. Personally identifiable information, such as an email address or phone number, should not be used in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internal_reference")]
    public string? InternalReference { get; init; }

    /// <summary>
    /// The timestamp when the incident occurred, in ISO 8601 format (e.g., '2020-07-24T03:26:02Z').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public DateTimeOffset? Time { get; init; }

    /// <summary>
    /// The monetary amount associated with the incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public ProtectIncidentAmount? Amount { get; init; }

    /// <summary>
    /// The <c>item_id</c> associated with the Item related to this incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
