using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the total monthly income
/// </summary>
public record TotalMonthlyIncomeInsights
{
    /// <summary>
    /// The aggregated income for the 30 days prior to subscription date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseline_amount")]
    public double? BaselineAmount { get; init; }

    /// <summary>
    /// The aggregated income of the last 30 days
    /// </summary>
    [JsonPropertyName("current_amount")]
    public required double CurrentAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
