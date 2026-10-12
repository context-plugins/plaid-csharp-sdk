using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The end user's monthly summary for the income source(s).
/// </summary>
public record CreditBankIncomeHistoricalSummary
{
    /// <summary>
    /// Total amount of earnings for the income source(s) of the user for the month in the summary.
    /// This may return an incorrect value if the summary includes income sources in multiple currencies.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-items-bank-income-sources-historical-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amount")]
    public double? TotalAmount { get; init; }

    /// <summary>
    /// The ISO 4217 currency code of the amount or balance.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-items-bank-income-sources-historical-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.
    /// Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-items-bank-income-sources-historical-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// Total amount of earnings for the income source(s) of the user for the month in the summary.
    /// This can contain multiple amounts, with each amount denominated in one unique currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amounts")]
    public IReadOnlyList<CreditAmountWithCurrency>? TotalAmounts { get; init; }

    /// <summary>
    /// The start date of the period covered in this monthly summary.
    /// This date will be the first day of the month, unless the month being covered is a partial month because it is the first month included in the summary and the date range being requested does not begin with the first day of the month.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The end date of the period included in this monthly summary.
    /// This date will be the last day of the month, unless the month being covered is a partial month because it is the last month included in the summary and the date range being requested does not end with the last day of the month.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public IReadOnlyList<CreditBankIncomeTransaction>? Transactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
