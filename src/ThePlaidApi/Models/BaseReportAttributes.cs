using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Calculated attributes derived from transaction-level data.
/// </summary>
public record BaseReportAttributes
{
    /// <summary>
    /// Prediction indicator of whether the account is a primary account. Only one account per account type across the items connected will have a value of true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_primary_account")]
    public bool? IsPrimaryAccount { get; init; }

    /// <summary>
    /// Value ranging from 0-1. The higher the score, the more confident we are of the account being the primary account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_account_score")]
    public double? PrimaryAccountScore { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions for a given account within the report time range (not counting any fees that were reversed within the time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count")]
    public int? NsfOverdraftTransactionsCount { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions within the last 30 days for a given account (not counting any fees that were reversed within the time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_30d")]
    public int? NsfOverdraftTransactionsCount30D { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions within the last 60 days for a given account (not counting any fees that were reversed within the time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_60d")]
    public int? NsfOverdraftTransactionsCount60D { get; init; }

    /// <summary>
    /// The number of net NSF fee transactions within the last 90 days for a given account (not counting any fees that were reversed within the time range).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_90d")]
    public int? NsfOverdraftTransactionsCount90D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the account in the time period of the report. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount")]
    public TotalInflowAmount? TotalInflowAmount { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the account in the last 30 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_30d")]
    public TotalInflowAmount30D? TotalInflowAmount30D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the account in the last 60 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_60d")]
    public TotalInflowAmount60D? TotalInflowAmount60D { get; init; }

    /// <summary>
    /// Total amount of debit transactions into the account in the last 90 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_inflow_amount_90d")]
    public TotalInflowAmount90D? TotalInflowAmount90D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the account in the time period of the report. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount")]
    public TotalOutflowAmount? TotalOutflowAmount { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the account in the last 30 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_30d")]
    public TotalOutflowAmount30D? TotalOutflowAmount30D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the account in the last 60 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_60d")]
    public TotalOutflowAmount60D? TotalOutflowAmount60D { get; init; }

    /// <summary>
    /// Total amount of credit transactions out of the account in the last 90 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_outflow_amount_90d")]
    public TotalOutflowAmount90D? TotalOutflowAmount90D { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
