using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Detailed information for the income source.
/// </summary>
public record CraBankIncomeSource
{
    /// <summary>
    /// The account ID with which this income source is associated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// A unique identifier for an income source. If the report is regenerated and a new <c>report_id</c> is created, the new report will have a new set of <c>income_source_id</c>s.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_source_id")]
    public string? IncomeSourceId { get; init; }

    /// <summary>
    /// The most common name or original description for the underlying income transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_description")]
    public string? IncomeDescription { get; init; }

    /// <summary>
    /// The income category.
    /// <c>BANK_INTEREST</c>: Interest earned from a bank account.
    /// <c>BENEFIT_OTHER</c>: Government benefits other than retirement, unemployment, child support, or disability. Currently used only in the UK, to represent benefits such as Cost of Living Payments.
    /// <c>CASH</c>: Deprecated and used only for existing legacy implementations. Has been replaced by <c>CASH_DEPOSIT</c> and <c>TRANSFER_FROM_APPLICATION</c>.
    /// <c>CASH_DEPOSIT</c>: A cash or check deposit.
    /// <c>CHILD_SUPPORT</c>: Child support payments received.
    /// <c>GIG_ECONOMY</c>: Income earned as a gig economy worker, e.g. driving for Uber, Lyft, Postmates, DoorDash, etc.
    /// <c>LONG_TERM_DISABILITY</c>: Disability payments, including Social Security disability benefits.
    /// <c>OTHER</c>: Income that could not be categorized as any other income category.
    /// <c>MILITARY</c>: Veterans benefits. Income earned as salary for serving in the military (e.g. through DFAS) will be classified as <c>SALARY</c> rather than <c>MILITARY</c>.
    /// <c>RENTAL</c>: Income earned from a rental property. Income may be identified as rental when the payment is received through a rental platform, e.g. Airbnb; rent paid directly by the tenant to the property owner (e.g. via cash, check, or ACH) will typically not be classified as rental income.
    /// <c>RETIREMENT</c>: Payments from private retirement systems, pensions, and government retirement programs, including Social Security retirement benefits.
    /// <c>SALARY</c>: Payment from an employer to an earner or other form of permanent employment.
    /// <c>TAX_REFUND</c>: A tax refund.
    /// <c>TRANSFER_FROM_APPLICATION</c>: Deposits from a money transfer app, such as Venmo, Cash App, or Zelle.
    /// <c>UNEMPLOYMENT</c>: Unemployment benefits. In the UK, includes certain low-income benefits such as the Universal Credit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_category")]
    public CreditBankIncomeCategory? IncomeCategory { get; init; }

    /// <summary>
    /// Minimum of all dates within the specific income sources in the user's bank account for days requested by the client.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// Maximum of all dates within the specific income sources in the user's bank account for days requested by the client.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The income pay frequency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_frequency")]
    public CreditBankIncomePayFrequency? PayFrequency { get; init; }

    /// <summary>
    /// Total amount of earnings in the user's bank account for the specific income source for days requested by the client.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_amount")]
    public double? TotalAmount { get; init; }

    /// <summary>
    /// The ISO 4217 currency code of the amount or balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.
    /// Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// Number of transactions for the income source within the start and end date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_count")]
    public int? TransactionCount { get; init; }

    /// <summary>
    /// The expected date of the end user's next paycheck for the income source.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_payment_date")]
    public DateTimeOffset? NextPaymentDate { get; init; }

    /// <summary>
    /// The status of the income sources.
    /// <c>ACTIVE</c>: The income source is active.
    /// <c>INACTIVE</c>: The income source is inactive.
    /// <c>UNKNOWN</c>: The income source status is unknown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public CraBankIncomeStatus? Status { get; init; }

    /// <summary>
    /// An estimate of the average gross monthly income based on the historical net amount and income category for the income source(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_average_monthly_gross_income")]
    public double? HistoricalAverageMonthlyGrossIncome { get; init; }

    /// <summary>
    /// The average monthly net income amount estimated based on the historical data for the income source(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_average_monthly_income")]
    public double? HistoricalAverageMonthlyIncome { get; init; }

    /// <summary>
    /// The predicted average monthly net income amount for the income source(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forecasted_average_monthly_income")]
    public double? ForecastedAverageMonthlyIncome { get; init; }

    /// <summary>
    /// The prediction interval(s) for the forecasted average monthly income.
    /// </summary>
    [JsonPropertyName("forecasted_average_monthly_income_prediction_intervals")]
    public required IReadOnlyList<CraPredictionInterval> ForecastedAverageMonthlyIncomePredictionIntervals { get; init; }

    /// <summary>
    /// The object containing employer data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer")]
    public CraBankIncomeEmployer? Employer { get; init; }

    /// <summary>
    /// The object containing data about the income provider.
    /// </summary>
    [JsonPropertyName("income_provider")]
    public required CraBankIncomeIncomeProvider? IncomeProvider { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_summary")]
    public IReadOnlyList<CraBankIncomeHistoricalSummary>? HistoricalSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
