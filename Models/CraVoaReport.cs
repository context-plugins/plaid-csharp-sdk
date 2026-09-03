using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a VOA report.
/// </summary>
public record CraVoaReport
{
    /// <summary>
    /// The date and time when the VOA Report was created, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (e.g. "2018-04-12T03:32:11Z").
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// The number of days of transaction history that the VOA report covers.
    /// </summary>
    [JsonPropertyName("days_requested")]
    public required double DaysRequested { get; init; }

    /// <summary>
    /// Data returned by Plaid about each of the Items included in the Base Report.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CraVoaReportItem> Items { get; init; }

    /// <summary>
    /// Attributes for the VOA report.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required CraVoaReportAttributes Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
