using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the extracted account.
/// </summary>
public record BaseReportAccountMetadata
{
    /// <summary>
    /// The beginning of the range of the financial institution provided data for the account, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The end of the range of the financial institution provided data for the account, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
