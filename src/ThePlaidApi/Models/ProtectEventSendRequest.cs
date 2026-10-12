using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request object for /protect/event/send
/// </summary>
public record ProtectEventSendRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Timestamp of the event. Might be the current moment or a time in the past. In <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }

    /// <summary>
    /// Event data for Protect events.
    /// </summary>
    [JsonPropertyName("event")]
    public required ProtectEvent? Event { get; init; }

    /// <summary>
    /// Protect Session ID should be provided for any event correlated with a frontend user session started via the Protect SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("protect_session_id")]
    public string? ProtectSessionId { get; init; }

    /// <summary>
    /// Whether this event should be scored with Trust Index. The default is false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_trust_index")]
    public bool? RequestTrustIndex { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
