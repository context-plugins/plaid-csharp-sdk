using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/metrics/get</c>
/// </summary>
public record TransferMetricsGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// Sum of dollar amount of debit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("daily_debit_transfer_volume")]
    public required string DailyDebitTransferVolume { get; init; }

    /// <summary>
    /// Sum of dollar amount of credit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("daily_credit_transfer_volume")]
    public required string DailyCreditTransferVolume { get; init; }

    /// <summary>
    /// Sum of dollar amount of credit and debit transfers in current calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("monthly_transfer_volume")]
    public required string MonthlyTransferVolume { get; init; }

    /// <summary>
    /// Sum of dollar amount of debit transfers in current calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("monthly_debit_transfer_volume")]
    public required string MonthlyDebitTransferVolume { get; init; }

    /// <summary>
    /// Sum of dollar amount of credit transfers in current calendar month (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("monthly_credit_transfer_volume")]
    public required string MonthlyCreditTransferVolume { get; init; }

    /// <summary>
    /// The currency of the dollar amount, e.g. "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// Details regarding return rates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_rates")]
    public TransferMetricsGetReturnRates? ReturnRates { get; init; }

    /// <summary>
    /// Details regarding authorization usage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_usage")]
    public TransferMetricsGetAuthorizationUsage? AuthorizationUsage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
