using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Comprehensive analysis of spending patterns, categorizing expenses into essential, non-essential, and other categories.
/// </summary>
public record ExpenditureInsights
{
    /// <summary>
    /// Net cash flow for the period (inflows minus outflows), including a monthly average.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_flow")]
    public AmountWithCurrencyWithMonthlyAverage? CashFlow { get; init; }

    /// <summary>
    /// Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_expenditure")]
    public ExpenditureSummary? TotalExpenditure { get; init; }

    /// <summary>
    /// Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("essential_expenditure")]
    public ExpenditureSummary? EssentialExpenditure { get; init; }

    /// <summary>
    /// Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("non_essential_expenditure")]
    public ExpenditureSummary? NonEssentialExpenditure { get; init; }

    /// <summary>
    /// Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("other")]
    public ExpenditureSummary? Other { get; init; }

    /// <summary>
    /// Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfers_out")]
    public ExpenditureSummary? TransfersOut { get; init; }

    /// <summary>
    /// Insights into unusually large transactions that exceed typical spending patterns for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outlier_transactions")]
    public OutlierTransactionsInsights? OutlierTransactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
