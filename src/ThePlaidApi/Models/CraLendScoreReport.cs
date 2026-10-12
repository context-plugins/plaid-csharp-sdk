using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains data for the CRA LendScore Report.
/// </summary>
public record CraLendScoreReport
{
    /// <summary>
    /// The unique identifier associated with the report object.
    /// </summary>
    [JsonPropertyName("report_id")]
    public required string ReportId { get; init; }

    /// <summary>
    /// The time when the report was generated.
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// The results of the LendScore
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lend_score")]
    public LendScore? LendScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
