using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights into gambling-related transactions, including frequency, amounts, and top merchants.
/// </summary>
public record GamblingIndicators
{
    /// <summary>
    /// The total value of transactions that fall into the <c>GAMBLING</c> credit category, across all the accounts in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the amount. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// The monthly average amount calculated by dividing the total by the number of calendar months in the time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_average")]
    public MonthlyAverage? MonthlyAverage { get; init; }

    /// <summary>
    /// Up to 3 top merchants that the user had the most transactions for in the given time window, in descending order of total spend.
    /// <para>
    /// If the user has not spent money on any merchants in the given time window, this list will be empty.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_merchants")]
    public IReadOnlyList<string>? TopMerchants { get; init; }

    /// <summary>
    /// The total number of transactions that fall into the <c>GAMBLING</c> credit category, across all the accounts in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_count")]
    public int? TransactionsCount { get; init; }

    /// <summary>
    /// The monthly summaries of the transactions that fall into the <c>GAMBLING</c> category within the given time window, across all the accounts in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_summaries")]
    public IReadOnlyList<MonthlySummary?>? MonthlySummaries { get; init; }

    /// <summary>
    /// The number of days since the last transaction that falls into the <c>GAMBLING</c> category, across all the accounts in the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_last_occurrence")]
    public int? DaysSinceLastOccurrence { get; init; }

    /// <summary>
    /// The percentage of the user's monthly inflows that was spent on transactions that fall into the <c>GAMBLING</c> category within the given time window, across all the accounts in the report. For example, a value of 100 indicates that 100% of the inflows were spent on transactions that fall into the <c>GAMBLING</c> credit category.
    /// If there's no available income for the given time period, this field value will be <c>-1</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage_of_income")]
    public double? PercentageOfIncome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
