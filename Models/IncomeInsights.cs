using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Comprehensive income analysis including total income, income excluding transfers, and inbound transfer amounts.
/// </summary>
public record IncomeInsights
{
    /// <summary>
    /// The total amount of all income transactions in the given time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_income")]
    public AmountWithCurrency? TotalIncome { get; init; }

    /// <summary>
    /// Income excluding account transfer transactions for the period, including a monthly average.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_excluding_transfers")]
    public AmountWithCurrencyWithMonthlyAverage? IncomeExcludingTransfers { get; init; }

    /// <summary>
    /// Sum of inbound transfer transactions for the period, including a monthly average.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfers_in")]
    public AmountWithCurrencyWithMonthlyAverage? TransfersIn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
