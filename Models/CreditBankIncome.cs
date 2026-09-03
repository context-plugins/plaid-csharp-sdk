using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The report of the Bank Income data for an end user.
/// </summary>
public record CreditBankIncome
{
    /// <summary>
    /// The unique identifier associated with the Bank Income Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_id")]
    public string? BankIncomeId { get; init; }

    /// <summary>
    /// The time when the report was generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generated_time")]
    public DateTimeOffset? GeneratedTime { get; init; }

    /// <summary>
    /// The number of days requested by the customer for the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    public int? DaysRequested { get; init; }

    /// <summary>
    /// The list of Items in the report along with the associated metadata about the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<CreditBankIncomeItem>? Items { get; init; }

    /// <summary>
    /// Summary for bank income across all income sources and items (max history of 730 days).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_summary")]
    public CreditBankIncomeSummary? BankIncomeSummary { get; init; }

    /// <summary>
    /// If data from the report was unable to be retrieved, the warnings will contain information about the error that caused the data to be incomplete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<CreditBankIncomeWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
