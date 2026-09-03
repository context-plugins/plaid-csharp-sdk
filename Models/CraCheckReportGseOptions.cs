using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for creating reports that can be shared with GSEs for mortgage verification.
/// </summary>
public record CraCheckReportGseOptions
{
    /// <summary>
    /// Specifies which types of reports should be made available to GSEs.
    /// </summary>
    [JsonPropertyName("report_types")]
    public required IReadOnlyList<GseReportType> ReportTypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
