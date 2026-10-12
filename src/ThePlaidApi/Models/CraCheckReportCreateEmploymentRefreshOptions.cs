using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines configuration options for the Employment Refresh Report.
/// </summary>
public record CraCheckReportCreateEmploymentRefreshOptions
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
