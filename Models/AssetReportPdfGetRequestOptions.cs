using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter or add data to <c>/asset_report/get</c> results. If provided, must be non-<c>null</c>.
/// </summary>
public record AssetReportPdfGetRequestOptions
{
    /// <summary>
    /// The maximum integer number of days of history to include in the Asset Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_to_include")]
    [Minimum(0)]
    [Maximum(731)]
    public int? DaysToInclude { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
