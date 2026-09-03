using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains data for the CRA Home Lending Report.
/// </summary>
public record CraVerificationReport
{
    /// <summary>
    /// The unique identifier associated with the Home Lending Report object. This ID will be the same as the Base Report ID.
    /// </summary>
    [JsonPropertyName("report_id")]
    public required string ReportId { get; init; }

    /// <summary>
    /// A unique token that can be shared with GSEs in order to provide them access to the report. This is automatically created during report generation when GSE options are specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gse_reference_id")]
    public string? GseReferenceId { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// An object representing a VOA report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("voa")]
    public CraVoaReport? Voa { get; init; }

    /// <summary>
    /// An object representing an Employment Refresh Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment_refresh")]
    public CraEmploymentRefreshReport? EmploymentRefresh { get; init; }

    /// <summary>
    /// An object representing an Income Report within the Home Lending Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income")]
    public CraVerificationIncomeReport? Income { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
