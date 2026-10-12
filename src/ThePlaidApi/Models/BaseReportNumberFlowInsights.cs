using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The number of credits or debits out of the account. This field will only be included for depository accounts.
/// </summary>
public record BaseReportNumberFlowInsights
{
    /// <summary>
    /// The start date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date of this time period.
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// The number of credits or debits out of the account for this time period.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
