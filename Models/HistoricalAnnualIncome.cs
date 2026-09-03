using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the historical annual income amount.
/// </summary>
public record HistoricalAnnualIncome
{
    /// <summary>
    /// The historical annual income at the time of subscription
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseline_amount")]
    public double? BaselineAmount { get; init; }

    /// <summary>
    /// The current historical annual income
    /// </summary>
    [JsonPropertyName("current_amount")]
    public required double CurrentAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
