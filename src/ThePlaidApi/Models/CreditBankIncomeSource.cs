using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Detailed information for the income source.
/// </summary>
public record CreditBankIncomeSource
{
    /// <summary>
    /// A unique identifier for an income source.
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
    /// Plaid's unique identifier for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

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
    /// Number of transactions for the income source within the start and end date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_count")]
    public int? TransactionCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("historical_summary")]
    public IReadOnlyList<CreditBankIncomeHistoricalSummary>? HistoricalSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
