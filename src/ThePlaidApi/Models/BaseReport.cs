using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a Base Report
/// </summary>
public record BaseReport
{
    /// <summary>
    /// A unique ID identifying a Base Report. Like all Plaid identifiers, this ID is case sensitive.
    /// </summary>
    [JsonPropertyName("report_id")]
    public required string ReportId { get; init; }

    /// <summary>
    /// The date and time when the Base Report was created, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("date_generated")]
    public required DateTimeOffset DateGenerated { get; init; }

    /// <summary>
    /// The number of days of transaction history requested.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required double DaysRequested { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// Data returned by Plaid about each of the Items included in the Base Report.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<BaseReportItem> Items { get; init; }

    /// <summary>
    /// Calculated attributes derived from transaction-level data, aggregated across accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public BaseReportUserAttributes? Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
