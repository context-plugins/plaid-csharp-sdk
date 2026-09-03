using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Event data for Protect events.
/// </summary>
public record ProtectEvent
{
    /// <summary>
    /// The timestamp of the event, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// If present, contains the current Protect Session ID from the Protect SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("protect_session_id")]
    public string? ProtectSessionId { get; init; }

    /// <summary>
    /// This event type represents a user visiting the client application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_visit")]
    public object? AppVisit { get; init; }

    /// <summary>
    /// This event type represents a user signing in to the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_sign_in")]
    public object? UserSignIn { get; init; }

    /// <summary>
    /// This event type represents a user signing up for the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_sign_up")]
    public object? UserSignUp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
