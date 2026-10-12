using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The object containing prediction interval data.
/// </summary>
public record CraPredictionInterval
{
    /// <summary>
    /// The lower bound of the predicted attribute for the given probability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lower_bound")]
    public double? LowerBound { get; init; }

    /// <summary>
    /// The upper bound of the predicted attribute for the given probability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upper_bound")]
    public double? UpperBound { get; init; }

    /// <summary>
    /// The probability of the actual value of the attribute falling within the upper and lower bound.
    /// This is a percentage represented as a value between 0 and 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("probability")]
    public double? Probability { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
