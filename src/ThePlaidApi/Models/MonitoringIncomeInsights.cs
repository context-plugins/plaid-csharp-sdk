using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the income subcategory of the report
/// </summary>
public record MonitoringIncomeInsights
{
    /// <summary>
    /// Details about the total monthly income
    /// </summary>
    [JsonPropertyName("total_monthly_income")]
    public required TotalMonthlyIncomeInsights TotalMonthlyIncome { get; init; }

    /// <summary>
    /// Details about the number of income sources
    /// </summary>
    [JsonPropertyName("income_sources_counts")]
    public required IncomeSourcesCounts IncomeSourcesCounts { get; init; }

    /// <summary>
    /// An object representing the predicted average monthly net income amount. This amount reflects the funds deposited into the account and may not include any withheld income such as taxes or other payroll deductions
    /// </summary>
    [JsonPropertyName("forecasted_monthly_income")]
    public required ForecastedMonthlyIncome ForecastedMonthlyIncome { get; init; }

    /// <summary>
    /// An object representing the historical annual income amount.
    /// </summary>
    [JsonPropertyName("historical_annual_income")]
    public required HistoricalAnnualIncome HistoricalAnnualIncome { get; init; }

    /// <summary>
    /// The income sources for this Item. Each entry in the array is a single income source
    /// </summary>
    [JsonPropertyName("income_sources")]
    public required IReadOnlyList<MonitoringIncomeSource> IncomeSources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
