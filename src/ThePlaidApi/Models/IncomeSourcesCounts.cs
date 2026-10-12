using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the number of income sources
/// </summary>
public record IncomeSourcesCounts
{
    /// <summary>
    /// The number of income sources detected at the subscription date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseline_count")]
    public double? BaselineCount { get; init; }

    /// <summary>
    /// The number of income sources currently detected
    /// </summary>
    [JsonPropertyName("current_count")]
    public required double CurrentCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
