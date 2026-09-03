using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The Check Income Insights Report for an end user.
/// </summary>
public record CraIncomeInsights
{
    /// <summary>
    /// The unique identifier associated with the Check Income Insights Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report_id")]
    public string? ReportId { get; init; }

    /// <summary>
    /// The time when the Check Income Insights Report was generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generated_time")]
    public DateTimeOffset? GeneratedTime { get; init; }

    /// <summary>
    /// The number of days requested by the customer for the Check Income Insights Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    public int? DaysRequested { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// The list of Items in the report along with the associated metadata about the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<CraBankIncomeItem>? Items { get; init; }

    /// <summary>
    /// Aggregated summary of all income streams for this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_summary")]
    public CraIncomeInsightsUserSummary? UserSummary { get; init; }

    /// <summary>
    /// The list of income streams for this user.
    /// </summary>
    [JsonPropertyName("income_streams")]
    public required IReadOnlyList<CraIncomeStream> IncomeStreams { get; init; }

    /// <summary>
    /// This is a V1 (II1) schema. For the V2 (II2) equivalent, use <c>CraIncomeInsightsUserSummary</c>. Summary for income across all income sources and items (max history of 730 days).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_summary")]
    public CraBankIncomeSummary? BankIncomeSummary { get; init; }

    /// <summary>
    /// If data from the report was unable to be retrieved, the warnings object will contain information about the error that caused the data to be incomplete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<CraBankIncomeWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
