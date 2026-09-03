using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The report of the Bank Employment data for an end user.
/// </summary>
public record CreditBankEmploymentReport
{
    /// <summary>
    /// The unique identifier associated with the Bank Employment Report.
    /// </summary>
    [JsonPropertyName("bank_employment_report_id")]
    public required string BankEmploymentReportId { get; init; }

    /// <summary>
    /// The time when the Bank Employment Report was generated, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// The number of days requested by the customer for the Bank Employment Report.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// The list of Items in the report along with the associated metadata about the Item.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CreditBankEmploymentItem> Items { get; init; }

    /// <summary>
    /// If data from the Bank Employment report was unable to be retrieved, the warnings will contain information about the error that caused the data to be incomplete.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<CreditBankEmploymentWarning> Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
