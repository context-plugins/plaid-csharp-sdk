using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// This webhook contains a summary of the events from a Link session and will be fired after the user finishes going through Link. If the user abandons the Link flow (i.e., closes the hosted link webpage or leaves Link open for too long without taking any action), the webhook will be fired 5-15 minutes after the last user interaction. A single Link session may occasionally generate multiple <c>EVENTS</c> webhooks. If this occurs, the new webhook will contain all previous events for the session, as well as new events that occurred since the previous <c>EVENTS</c> webhook was sent. If this occurs, events can be grouped using the <c>link_session_id</c> field and, if necessary, de-duplicated using the <c>event_id</c> field.
/// <para>
/// By default, the <c>EVENTS</c> webhook is sent only for sessions where the end user goes through a Hosted Link flow (including Link Recovery flows). If you would like to receive this webhook for sessions not using Hosted Link, contact your account manager or support. This enablement will also cause you to receive the <c>SESSION_FINISHED</c> webhook for non-Hosted-Link sessions and to be able to use <c>/link/token/get</c> to receive events data for non-Hosted Link sessions.
/// </para>
/// </summary>
public record LinkEventsWebhook
{
    /// <summary>
    /// <c>LINK</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>EVENTS</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The Link events emitted during the Link session
    /// </summary>
    [JsonPropertyName("events")]
    public required IReadOnlyList<LinkEvent> Events { get; init; }

    /// <summary>
    /// An identifier for the Link session these events occurred in
    /// </summary>
    [JsonPropertyName("link_session_id")]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// The Link token used to create the Link session these events are from
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
