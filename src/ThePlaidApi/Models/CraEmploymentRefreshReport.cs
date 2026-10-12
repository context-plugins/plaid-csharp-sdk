using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an Employment Refresh Report.
/// </summary>
public record CraEmploymentRefreshReport
{
    /// <summary>
    /// The date and time when the Employment Refresh Report was created, in ISO 8601 format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// The number of days of transaction history that the Employment Refresh Report covers.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required double DaysRequested { get; init; }

    /// <summary>
    /// Data returned by Plaid about each of the Items included in the Employment Refresh Report.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CraEmploymentRefreshReportItem> Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
