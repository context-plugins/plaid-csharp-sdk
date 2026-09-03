using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An income stream detected for the user.
/// </summary>
public record CraIncomeStream
{
    /// <summary>
    /// A unique identifier for an income stream. If the report is regenerated and a new <c>report_id</c> is created, the new report will have a new set of <c>income_stream_id</c>s.
    /// </summary>
    [JsonPropertyName("income_stream_id")]
    public required string IncomeStreamId { get; init; }

    /// <summary>
    /// Minimum of all dates within the specific income stream for days requested by the client. The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// Maximum of all dates within the specific income stream for days requested by the client. The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// The most common name or original description for the underlying income transactions.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Modeled insights for a given income stream.
    /// </summary>
    [JsonPropertyName("insights")]
    public required CraIncomeStreamInsights Insights { get; init; }

    /// <summary>
    /// Modeled income metrics for a given income stream or user summary.
    /// </summary>
    [JsonPropertyName("income_metrics")]
    public required CraIncomeMetrics IncomeMetrics { get; init; }

    /// <summary>
    /// The transactions data for the income stream ordered by ascending date.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<CraIncomeTransaction> Transactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
