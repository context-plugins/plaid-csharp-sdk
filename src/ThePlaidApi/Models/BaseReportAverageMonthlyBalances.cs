using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Average balance in dollar amount per month
/// </summary>
public record BaseReportAverageMonthlyBalances
{
    /// <summary>
    /// The start date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required string StartDate { get; init; }

    /// <summary>
    /// The end date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required string EndDate { get; init; }

    /// <summary>
    /// This contains an amount, denominated in the currency specified by either <c>iso_currency_code</c> or <c>unofficial_currency_code</c>
    /// </summary>
    [JsonPropertyName("average_balance")]
    public required CreditAmountWithCurrency AverageBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
