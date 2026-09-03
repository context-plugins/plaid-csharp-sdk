using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Edit counts over various time periods.
/// </summary>
public record UserAccountIdentityEditCounts
{
    /// <summary>
    /// Number of edits in the current session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edits_current")]
    public int? EditsCurrent { get; init; }

    /// <summary>
    /// Number of edits in the last 1 day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edits_1d")]
    public int? Edits1D { get; init; }

    /// <summary>
    /// Number of edits in the last 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edits_30d")]
    public int? Edits30D { get; init; }

    /// <summary>
    /// Number of edits in the last 365 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edits_365d")]
    public int? Edits365D { get; init; }

    /// <summary>
    /// Total number of edits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edits_all_time")]
    public int? EditsAllTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
