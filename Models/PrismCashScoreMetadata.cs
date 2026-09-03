using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing metadata about the provided transactions.
/// </summary>
public record PrismCashScoreMetadata
{
    /// <summary>
    /// Number of days since the oldest transaction.
    /// </summary>
    [JsonPropertyName("max_age")]
    public required int? MaxAge { get; init; }

    /// <summary>
    /// Number of days since the latest transaction.
    /// </summary>
    [JsonPropertyName("min_age")]
    public required int? MinAge { get; init; }

    /// <summary>
    /// Number of days since the latest credit transaction.
    /// </summary>
    [JsonPropertyName("min_age_credit")]
    public required int? MinAgeCredit { get; init; }

    /// <summary>
    /// Number of days since the latest debit transaction.
    /// </summary>
    [JsonPropertyName("min_age_debit")]
    public required int? MinAgeDebit { get; init; }

    /// <summary>
    /// Number of days since the oldest debit transaction.
    /// </summary>
    [JsonPropertyName("max_age_debit")]
    public required int? MaxAgeDebit { get; init; }

    /// <summary>
    /// Number of days since the oldest credit transaction.
    /// </summary>
    [JsonPropertyName("max_age_credit")]
    public required int? MaxAgeCredit { get; init; }

    /// <summary>
    /// Number of credit transactions.
    /// </summary>
    [JsonPropertyName("num_trxn_credit")]
    public required int? NumTrxnCredit { get; init; }

    /// <summary>
    /// Number of debit transactions.
    /// </summary>
    [JsonPropertyName("num_trxn_debit")]
    public required int? NumTrxnDebit { get; init; }

    /// <summary>
    /// Number of credit transactions in the last 30 days.
    /// </summary>
    [JsonPropertyName("l1m_credit_value_cnt")]
    public required int? L1MCreditValueCnt { get; init; }

    /// <summary>
    /// Number of debit transactions in the last 30 days.
    /// </summary>
    [JsonPropertyName("l1m_debit_value_cnt")]
    public required int? L1MDebitValueCnt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
