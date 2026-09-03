using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The Partner Insights report of the bank data for an end user.
/// </summary>
public record CraPartnerInsights
{
    /// <summary>
    /// A unique identifier associated with the Partner Insights object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report_id")]
    public string? ReportId { get; init; }

    /// <summary>
    /// The time when the Partner Insights report was generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generated_time")]
    public DateTimeOffset? GeneratedTime { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// The calculated UltraFICO® scores returned as part of the Partner Insights report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fico")]
    public CraPartnerInsightsFicoResults? Fico { get; init; }

    /// <summary>
    /// The Prism Data insights for the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prism")]
    public CraPartnerInsightsPrism? Prism { get; init; }

    /// <summary>
    /// The list of Items used in the report along with the associated metadata about the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<CraPartnerInsightsItem>? Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
