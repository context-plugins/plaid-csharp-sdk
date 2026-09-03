using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportGetRequest defines the request schema for <c>/asset_report/get</c>
/// </summary>
public record AssetReportGetRequest
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
    /// A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asset_report_token")]
    public string? AssetReportToken { get; init; }

    /// <summary>
    /// The user token associated with the User for which to create an asset report for. The latest asset report associated with the User will be returned
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_token")]
    public string? UserToken { get; init; }

    /// <summary>
    /// <c>true</c> if you would like to retrieve the Asset Report with Insights, <c>false</c> otherwise. This field defaults to <c>false</c> if omitted.
    /// </summary>
    [JsonPropertyName("include_insights")]
    public bool? IncludeInsights { get; init; } = false;

    /// <summary>
    /// <c>true</c> to fetch "fast" version of asset report. Defaults to false if omitted. Can only be used if <c>/asset_report/create</c> was called with <c>options.add_ons</c> set to <c>["fast_assets"]</c>.
    /// </summary>
    [JsonPropertyName("fast_report")]
    public bool? FastReport { get; init; } = false;

    /// <summary>
    /// An optional object to filter or add data to <c>/asset_report/get</c> results. If provided, must be non-<c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public AssetReportGetRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
