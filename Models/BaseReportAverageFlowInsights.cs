using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Average dollar amount of credit or debit transactions out of the account. This field will only be included for depository accounts.
/// </summary>
public record BaseReportAverageFlowInsights
{
    /// <summary>
    /// The start date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// This contains an amount, denominated in the currency specified by either <c>iso_currency_code</c> or <c>unofficial_currency_code</c>
    /// </summary>
    [JsonPropertyName("total_amount")]
    public required CreditAmountWithCurrency TotalAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
