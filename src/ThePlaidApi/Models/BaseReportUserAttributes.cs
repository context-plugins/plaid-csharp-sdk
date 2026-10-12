using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Calculated attributes derived from transaction-level data, aggregated across accounts.
/// </summary>
public record BaseReportUserAttributes
{
    /// <summary>
    /// The number of net NSF fee transactions in the time range for the report (not counting any fees that were reversed within that time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count")]
    public int? NsfOverdraftTransactionsCount { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions in the last 30 days in the report (not counting any fees that were reversed within that time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_30d")]
    public int? NsfOverdraftTransactionsCount30D { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions in the last 60 days in the report (not counting any fees that were reversed within that time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_60d")]
    public int? NsfOverdraftTransactionsCount60D { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions in the last 90 days in the report (not counting any fees that were reversed within that time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_90d")]
    public int? NsfOverdraftTransactionsCount90D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount")]
    public TotalReportInflowAmount? TotalInflowAmount { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the report's accounts in the last 30 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_30d")]
    public TotalReportInflowAmount30D? TotalInflowAmount30D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the report's accounts in the last 60 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_60d")]
    public TotalReportInflowAmount60D? TotalInflowAmount60D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the report's accounts in the last 90 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_90d")]
    public TotalReportInflowAmount90D? TotalInflowAmount90D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount")]
    public TotalReportOutflowAmount? TotalOutflowAmount { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the report's accounts in the last 30 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_30d")]
    public TotalReportOutflowAmount30D? TotalOutflowAmount30D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the report's accounts in the last 60 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_60d")]
    public TotalReportOutflowAmount60D? TotalOutflowAmount60D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the report's accounts in the last 90 days. This field only takes into account USD transactions from the accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_90d")]
    public TotalReportOutflowAmount90D? TotalOutflowAmount90D { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
