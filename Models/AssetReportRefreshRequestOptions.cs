using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/asset_report/refresh</c> results. If provided, cannot be <c>null</c>. If not specified, the <c>options</c> from the original call to <c>/asset_report/create</c> will be used.
/// </summary>
public record AssetReportRefreshRequestOptions
{
    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    /// <summary>
    /// The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae's Day 1 Certainty™ program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public AssetReportUser? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
