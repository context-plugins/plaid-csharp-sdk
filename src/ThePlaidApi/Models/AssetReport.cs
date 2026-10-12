using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an Asset Report
/// </summary>
public record AssetReport
{
    /// <summary>
    /// A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.
    /// </summary>
    [JsonPropertyName("asset_report_id")]
    public required string AssetReportId { get; init; }

    /// <summary>
    /// This is a container object for all lending-related insights. This field will be returned only for European customers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insights")]
    public AccountInsights? Insights { get; init; }

    /// <summary>
    /// An identifier you determine and submit for the Asset Report.
    /// </summary>
    [JsonPropertyName("client_report_id")]
    public required string? ClientReportId { get; init; }

    /// <summary>
    /// The date and time when the Asset Report was created, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("date_generated")]
    public required DateTimeOffset DateGenerated { get; init; }

    /// <summary>
    /// The duration of transaction history you requested
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required double DaysRequested { get; init; }

    /// <summary>
    /// The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae's Day 1 Certainty™ program.
    /// </summary>
    [JsonPropertyName("user")]
    public required AssetReportUser User { get; init; }

    /// <summary>
    /// Data returned by Plaid about each of the Items included in the Asset Report.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<AssetReportItem> Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
