using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains data for the CRA Cashflow Insights Report.
/// </summary>
public record CraCashflowInsightsReport
{
    /// <summary>
    /// The unique identifier associated with the report object.
    /// </summary>
    [JsonPropertyName("report_id")]
    public required string ReportId { get; init; }

    /// <summary>
    /// The time when the report was generated.
    /// </summary>
    [JsonPropertyName("generated_time")]
    public required DateTimeOffset GeneratedTime { get; init; }

    /// <summary>
    /// A map of cash flow attributes, where the key is a string, and the value is a string, float, int, or boolean. The specific list of attributes will depend on the cash flow attributes version used. For a full list of attributes, contact your account manager.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public object? Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
