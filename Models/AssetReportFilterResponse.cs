using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportFilterResponse defines the response schema for <c>/asset_report/filter</c>
/// </summary>
public record AssetReportFilterResponse
{
    /// <summary>
    /// A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.
    /// </summary>
    [JsonPropertyName("asset_report_token")]
    public required string AssetReportToken { get; init; }

    /// <summary>
    /// A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.
    /// </summary>
    [JsonPropertyName("asset_report_id")]
    public required string AssetReportId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
