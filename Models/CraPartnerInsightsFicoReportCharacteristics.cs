using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Report characteristics returned by FICO describing the banking data used to generate the UltraFICO® score.
/// </summary>
public record CraPartnerInsightsFicoReportCharacteristics
{
    /// <summary>
    /// Total number of accounts included in the report. Limited to checking, savings, and money market accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_accounts")]
    public int? NumAccounts { get; init; }

    /// <summary>
    /// Average daily balance over the past 1 month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avg_daily_balance_over_1_month")]
    public double? AvgDailyBalanceOver1Month { get; init; }

    /// <summary>
    /// Average daily balance over the past 3 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avg_daily_balance_over_3_months")]
    public double? AvgDailyBalanceOver3Months { get; init; }

    /// <summary>
    /// Average daily balance over the past 6 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avg_daily_balance_over_6_months")]
    public double? AvgDailyBalanceOver6Months { get; init; }

    /// <summary>
    /// Average daily balance over the past 12 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avg_daily_balance_over_12_months")]
    public double? AvgDailyBalanceOver12Months { get; init; }

    /// <summary>
    /// Number of days since the earliest transaction in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_earliest_tx")]
    public int? DaysSinceEarliestTx { get; init; }

    /// <summary>
    /// Number of days since the most recent day with a negative ending balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_most_recent_negative_ending_balance")]
    public int? DaysSinceMostRecentNegativeEndingBalance { get; init; }

    /// <summary>
    /// Number of days since the most recent insufficient funds fee debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_most_recent_insufficient_funds_fee_debit_tx")]
    public int? DaysSinceMostRecentInsufficientFundsFeeDebitTx { get; init; }

    /// <summary>
    /// Total number of days with a negative balance over the past 1 month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tot_number_days_with_negative_balance_over_1_month")]
    public int? TotNumberDaysWithNegativeBalanceOver1Month { get; init; }

    /// <summary>
    /// Total number of days with a negative balance over the past 3 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tot_number_days_with_negative_balance_over_3_months")]
    public int? TotNumberDaysWithNegativeBalanceOver3Months { get; init; }

    /// <summary>
    /// Total number of days with a negative balance over the past 6 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tot_number_days_with_negative_balance_over_6_months")]
    public int? TotNumberDaysWithNegativeBalanceOver6Months { get; init; }

    /// <summary>
    /// Total number of days with a negative balance over the past 12 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tot_number_days_with_negative_balance_over_12_months")]
    public int? TotNumberDaysWithNegativeBalanceOver12Months { get; init; }

    /// <summary>
    /// Number of days since the most recent transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_most_recent_tx")]
    public int? DaysSinceMostRecentTx { get; init; }

    /// <summary>
    /// Number of days with at least one transaction over the past 1 month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_tx_over_1_month")]
    public int? DaysWithTxOver1Month { get; init; }

    /// <summary>
    /// Number of days with at least one transaction over the past 3 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_tx_over_3_months")]
    public int? DaysWithTxOver3Months { get; init; }

    /// <summary>
    /// Number of days with at least one transaction over the past 6 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_tx_over_6_months")]
    public int? DaysWithTxOver6Months { get; init; }

    /// <summary>
    /// Number of days with at least one transaction over the past 12 months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_tx_over_12_months")]
    public int? DaysWithTxOver12Months { get; init; }

    /// <summary>
    /// Sum of current balances across all accounts in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tot_current_balances")]
    public double? TotCurrentBalances { get; init; }

    /// <summary>
    /// Number of checking accounts included in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_checking_accounts")]
    public int? NumCheckingAccounts { get; init; }

    /// <summary>
    /// Number of money market accounts included in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_money_market_accounts")]
    public int? NumMoneyMarketAccounts { get; init; }

    /// <summary>
    /// Number of savings accounts included in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_savings_accounts")]
    public int? NumSavingsAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
