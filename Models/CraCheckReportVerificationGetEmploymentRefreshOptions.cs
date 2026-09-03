using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>employment_refresh_options</c>.
/// </summary>
public record CraCheckReportVerificationGetEmploymentRefreshOptions
{
    /// <summary>
    /// The number of days of data to request for the report. This field is required if an Employment Refresh Report is requested. Maximum is 731.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Maximum(731)]
    public required int DaysRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
