using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Conveys information on if a retry is recommended on a given date
/// </summary>
public record SignalScheduleRecommendation
{
    /// <summary>
    /// The specific date for submitting the debit entry, formatted in ISO 8601 (e.g., "2025-01-17").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The recommendation result for that date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recommendation")]
    public RecommendationString? Recommendation { get; init; }

    /// <summary>
    /// The rank of the recommendation based on the likelihood of debit success, with 1 representing the most optimal date. Dates with <c>NOT_RECOMMENDED</c> or <c>UNKNOWN</c> will have rank <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rank")]
    public int? Rank { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
