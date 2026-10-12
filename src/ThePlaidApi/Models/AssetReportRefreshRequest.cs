using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportRefreshRequest defines the request schema for <c>/asset_report/refresh</c>
/// </summary>
public record AssetReportRefreshRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The <c>asset_report_token</c> returned by the original call to <c>/asset_report/create</c>
    /// </summary>
    [JsonPropertyName("asset_report_token")]
    public required string AssetReportToken { get; init; }

    /// <summary>
    /// The maximum number of days of history to include in the Asset Report. Must be an integer. If not specified, the value from the original call to <c>/asset_report/create</c> will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    [Minimum(0)]
    [Maximum(731)]
    public int? DaysRequested { get; init; }

    /// <summary>
    /// An optional object to filter <c>/asset_report/refresh</c> results. If provided, cannot be <c>null</c>. If not specified, the <c>options</c> from the original call to <c>/asset_report/create</c> will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public AssetReportRefreshRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
