using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Summary for bank income across all income sources and items (max history of 730 days).
/// </summary>
public record CreditBankIncomeSummary
{
    /// <summary>
    /// Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.
    /// This may return an incorrect value if the summary includes income sources in multiple currencies.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amount")]
    public double? TotalAmount { get; init; }

    /// <summary>
    /// The ISO 4217 currency code of the amount or balance.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.
    /// Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// Please use <see href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></see> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.
    /// This can contain multiple amounts, with each amount denominated in one unique currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amounts")]
    public IReadOnlyList<CreditAmountWithCurrency>? TotalAmounts { get; init; }

    /// <summary>
    /// The earliest date within the days requested in which all income sources identified by Plaid appear in a user's account.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The latest date in which all income sources identified by Plaid appear in the user's account.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// Number of income sources per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_sources_count")]
    public int? IncomeSourcesCount { get; init; }

    /// <summary>
    /// Number of income categories per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_categories_count")]
    public int? IncomeCategoriesCount { get; init; }

    /// <summary>
    /// Number of income transactions per end user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_transactions_count")]
    public int? IncomeTransactionsCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_summary")]
    public IReadOnlyList<CreditBankIncomeHistoricalSummary>? HistoricalSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
