using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the predicted average monthly net income amount. This amount reflects the funds deposited into the account and may not include any withheld income such as taxes or other payroll deductions
/// </summary>
public record ForecastedMonthlyIncome
{
    /// <summary>
    /// The forecasted monthly income at the time of subscription
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseline_amount")]
    public double? BaselineAmount { get; init; }

    /// <summary>
    /// The current forecasted monthly income
    /// </summary>
    [JsonPropertyName("current_amount")]
    public required double CurrentAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
