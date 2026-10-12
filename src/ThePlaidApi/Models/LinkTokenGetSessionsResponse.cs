using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing information about a link session. Session data will be provided for up to six hours after the session has ended.
/// </summary>
public record LinkTokenGetSessionsResponse
{
    /// <summary>
    /// The unique ID for the link session.
    /// </summary>
    [JsonPropertyName("link_session_id")]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// The timestamp at which the link session was first started, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("started_at")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// The timestamp at which the link session was finished, if available, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finished_at")]
    public DateTimeOffset? FinishedAt { get; init; }

    /// <summary>
    /// An object representing an <see href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</see> callback from Link. This field is returned only for legacy integrations and is deprecated in favor of <see href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_results</c></see> which can support multiple public tokens in a single Link session, for flows such as multi-Item Link. If you are receiving <c>on_success</c>, contact your account manager to migrate to <c>results.item_add_results</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_success")]
    public LinkSessionSuccess? OnSuccess { get; init; }

    /// <summary>
    /// An object representing an <see href="https://plaid.com/docs/link/web/#onexit">onExit</see> callback from Link. This field is returned only for legacy implementations and has been deprecated in favor of <see href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-exit"><c>exit</c></see>, for improved naming consistency. If you are receiving this field, contact your account manager to migrate to the newer <c>exit</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_exit")]
    public LinkSessionExitDeprecated? OnExit { get; init; }

    /// <summary>
    /// An object representing an <see href="https://plaid.com/docs/link/web/#onexit">onExit</see> callback from Link. If you are not receiving this field and are instead receiving the deprecated <c>on_exit</c> field, contact your account manager to update your integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exit")]
    public LinkSessionExit? Exit { get; init; }

    /// <summary>
    /// List of customer-related Link events
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<LinkEvent>? Events { get; init; }

    /// <summary>
    /// The set of results for a Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public LinkSessionResults? Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
