using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Options for configuring Home Lending Report (Verification Report) generation.
/// </summary>
public record CraCheckReportHomeLendingReportOptions
{
    /// <summary>
    /// Specifies which types of home lending reports to generate.
    /// </summary>
    [JsonPropertyName("reports_requested")]
    public required IReadOnlyList<CraCheckReportVerificationGetReportType> ReportsRequested { get; init; }

    /// <summary>
    /// Defines configuration options for the Employment Refresh Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment_refresh_options")]
    public CraCheckReportCreateEmploymentRefreshOptions? EmploymentRefreshOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
