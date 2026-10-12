using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// This is a V1 (II1) schema. For the V2 (II2) equivalent, use <c>CraIncomeInsightsUserSummary</c>. Summary for income across all income sources and items (max history of 730 days).
/// </summary>
public record CraBankIncomeSummary
{
    /// <summary>
    /// Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.
    /// This can contain multiple amounts, with each amount denominated in one unique currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amounts")]
    public IReadOnlyList<CreditAmountWithCurrency>? TotalAmounts { get; init; }

    /// <summary>
    /// The earliest date within the days requested in which all income sources identified by Plaid appear in a user's account.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The latest date in which all income sources identified by Plaid appear in the user's account.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// Number of income sources per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_sources_count")]
    public int? IncomeSourcesCount { get; init; }

    /// <summary>
    /// Number of income categories per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_categories_count")]
    public int? IncomeCategoriesCount { get; init; }

    /// <summary>
    /// Number of income transactions per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_transactions_count")]
    public int? IncomeTransactionsCount { get; init; }

    /// <summary>
    /// An estimate of the average gross monthly income based on the historical net amount and income category for the income source(s). The average monthly income is calculated based on the lifetime of the income stream, rather than the entire historical period included in the scope of the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_average_monthly_gross_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? HistoricalAverageMonthlyGrossIncome { get; init; }

    /// <summary>
    /// The average monthly income amount estimated based on the historical data for the income source(s). The average monthly income is calculated based on the lifetime of the income stream, rather than the entire historical period included in the scope of the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_average_monthly_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? HistoricalAverageMonthlyIncome { get; init; }

    /// <summary>
    /// The predicted average monthly income amount for the income source(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forecasted_average_monthly_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? ForecastedAverageMonthlyIncome { get; init; }

    /// <summary>
    /// An estimate of the annual gross income for the income source, calculated by multiplying the <c>historical_average_monthly_gross_income</c> by 12.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_annual_gross_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? HistoricalAnnualGrossIncome { get; init; }

    /// <summary>
    /// An estimate of the annual net income for the income source, calculated by multiplying the <c>historical_average_monthly_income</c> by 12.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_annual_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? HistoricalAnnualIncome { get; init; }

    /// <summary>
    /// The predicted average annual income amount for the income source(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forecasted_annual_income")]
    public IReadOnlyList<CreditAmountWithCurrency>? ForecastedAnnualIncome { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_summary")]
    public IReadOnlyList<CraBankIncomeHistoricalSummary>? HistoricalSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
