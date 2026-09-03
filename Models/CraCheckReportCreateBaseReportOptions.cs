using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines configuration options to generate a Base Report
/// </summary>
public record CraCheckReportCreateBaseReportOptions
{
    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications. This field is deprecated. Use the <c>client_report_id</c> field at the top level of the request instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// Specifies options for creating reports that can be shared with GSEs for mortgage verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gse_options")]
    public CraCheckReportGseOptions? GseOptions { get; init; }

    /// <summary>
    /// Indicates that the report must include identity information. If identity information is not available, the report will fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("require_identity")]
    public bool? RequireIdentity { get; init; }

    /// <summary>
    /// Options for configuring Home Lending Report (Verification Report) generation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("home_lending_report_options")]
    public CraCheckReportHomeLendingReportOptions? HomeLendingReportOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
