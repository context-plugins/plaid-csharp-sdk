using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when there has been a new user event. The webhook payload contains limited information about the event. For full event details, call <see href="https://plaid.com/docs/api/products/protect/#protecteventget"><c>/protect/event/get</c></see>.
/// </summary>
public record ProtectUserEventWebhook
{
    /// <summary>
    /// <c>"PROTECT"</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>PROTECT_USER_EVENT</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The event ID of the user event that occurred.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; init; }

    /// <summary>
    /// The type of user event that occurred. Possible values include <c>LINK_COMPLETE</c> (the Link session has finished and a Trust Index score has been computed without waiting for transaction extraction) and <c>PROTECT_RUN_FINISH</c> (extraction-required scoring is complete, including transaction extraction; may arrive 30 seconds or more after Link completion).
    /// </summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>
    /// The timestamp of the event, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// The Plaid User ID.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string? UserId { get; init; }

    /// <summary>
    /// The <c>client_user_id</c> provided by the client when the user was created via <c>/user/create</c> or Link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// An identifier for the Link session this event occurred in
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
