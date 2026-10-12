using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata and results for a Link session
/// </summary>
public record CreditSession
{
    /// <summary>
    /// The unique identifier associated with the Link session. This identifier matches the <c>link_session_id</c> returned in the onSuccess/onExit callbacks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// The time when the Link session started
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("session_start_time")]
    public DateTimeOffset? SessionStartTime { get; init; }

    /// <summary>
    /// The set of results for a Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public CreditSessionResults? Results { get; init; }

    /// <summary>
    /// The set of errors that occurred during the Link session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<CreditSessionError>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
