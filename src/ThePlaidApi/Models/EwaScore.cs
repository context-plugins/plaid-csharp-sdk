using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// EwaScore represents an earned wage access score for a specific advance amount range.
/// </summary>
public record EwaScore
{
    /// <summary>
    /// Float value representing the lower bound (inclusive) of the advance amount range associated with a specific EWA score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lowest_amount")]
    public double? LowestAmount { get; init; }

    /// <summary>
    /// Float value representing the upper bound (exclusive) of the advance amount range associated with a specific EWA score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("highest_amount")]
    public double? HighestAmount { get; init; }

    /// <summary>
    /// EWA score for the corresponding amount bucket. Scores range from 1-99, where a higher score indicates a higher likelihood of repayment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
