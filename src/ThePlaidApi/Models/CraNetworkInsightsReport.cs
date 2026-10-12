using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains data for the CRA Network Attributes Report.
/// </summary>
public record CraNetworkInsightsReport
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
    /// A map of network attributes, where the key is a string, and the value is a float, int, or boolean. For a full list of attributes, contact your account manager.
    /// </summary>
    [JsonPropertyName("network_attributes")]
    public required object NetworkAttributes { get; init; }

    /// <summary>
    /// The Items the end user connected in Link.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<CraNetworkInsightsItem> Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
