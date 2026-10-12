using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes a historical log of user consent events.
/// </summary>
public record ItemActivityListResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A list of activities.
    /// </summary>
    [JsonPropertyName("activities")]
    public required IReadOnlyList<Activity> Activities { get; init; }

    /// <summary>
    /// An array of objects containing timestamps for the last time each data type was accessed per application.
    /// </summary>
    [JsonPropertyName("last_data_access_times")]
    public required IReadOnlyList<LastDataAccessTimes> LastDataAccessTimes { get; init; }

    /// <summary>
    /// Cursor used for pagination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
