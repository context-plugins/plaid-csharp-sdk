using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/configuration/get</c>
/// </summary>
public record TransferConfigurationGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The max limit of dollar amount of a single transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_single_transfer_amount")]
    public required string MaxSingleTransferAmount { get; init; }

    /// <summary>
    /// The max limit of dollar amount of a single credit transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_single_transfer_credit_amount")]
    public required string MaxSingleTransferCreditAmount { get; init; }

    /// <summary>
    /// The max limit of dollar amount of a single debit transfer (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_single_transfer_debit_amount")]
    public required string MaxSingleTransferDebitAmount { get; init; }

    /// <summary>
    /// The max limit of sum of dollar amount of credit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_daily_credit_amount")]
    public required string MaxDailyCreditAmount { get; init; }

    /// <summary>
    /// The max limit of sum of dollar amount of debit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_daily_debit_amount")]
    public required string MaxDailyDebitAmount { get; init; }

    /// <summary>
    /// The max limit of sum of dollar amount of credit and debit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_monthly_amount")]
    public required string MaxMonthlyAmount { get; init; }

    /// <summary>
    /// The max limit of sum of dollar amount of credit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_monthly_credit_amount")]
    public required string MaxMonthlyCreditAmount { get; init; }

    /// <summary>
    /// The max limit of sum of dollar amount of debit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("max_monthly_debit_amount")]
    public required string MaxMonthlyDebitAmount { get; init; }

    /// <summary>
    /// The currency of the dollar amount, e.g. "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
