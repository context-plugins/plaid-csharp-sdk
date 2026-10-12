using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Calculated insights derived from transaction-level data. This field has been deprecated in favor of <see href="https://plaid.com/docs/api/products/check/#cra-check_report-base_report-get-response-report-attributes">Base Report attributes aggregated across accounts</see> and will be removed in a future release.
/// </summary>
public record BaseReportAccountInsights
{
    /// <summary>
    /// Date of the earliest transaction for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldest_transaction_date")]
    public DateTimeOffset? OldestTransactionDate { get; init; }

    /// <summary>
    /// Date of the most recent transaction for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("most_recent_transaction_date")]
    public DateTimeOffset? MostRecentTransactionDate { get; init; }

    /// <summary>
    /// Number of days available for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_available")]
    public int? DaysAvailable { get; init; }

    /// <summary>
    /// Average number of days between sequential transactions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average_days_between_transactions")]
    public double? AverageDaysBetweenTransactions { get; init; }

    /// <summary>
    /// Longest gap between sequential transactions in a time period. This array can include multiple time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longest_gaps_between_transactions")]
    public IReadOnlyList<BaseReportLongestGapInsights>? LongestGapsBetweenTransactions { get; init; }

    /// <summary>
    /// The number of debits into the account. This array will be empty for non-depository accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_of_inflows")]
    public IReadOnlyList<BaseReportNumberFlowInsights>? NumberOfInflows { get; init; }

    /// <summary>
    /// Average amount of debit transactions into the account in a time period. This array will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average_inflow_amounts")]
    public IReadOnlyList<BaseReportAverageFlowInsights>? AverageInflowAmounts { get; init; }

    /// <summary>
    /// The number of outflows from the account. This array will be empty for non-depository accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_of_outflows")]
    public IReadOnlyList<BaseReportNumberFlowInsights>? NumberOfOutflows { get; init; }

    /// <summary>
    /// Average amount of transactions out of the account in a time period. This array will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average_outflow_amounts")]
    public IReadOnlyList<BaseReportAverageFlowInsights>? AverageOutflowAmounts { get; init; }

    /// <summary>
    /// Number of days with no transactions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_of_days_no_transactions")]
    public int? NumberOfDaysNoTransactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
