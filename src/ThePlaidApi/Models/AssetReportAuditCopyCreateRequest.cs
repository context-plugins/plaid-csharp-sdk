using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportAuditCopyCreateRequest defines the request schema for <c>/asset_report/audit_copy/create</c>
/// </summary>
public record AssetReportAuditCopyCreateRequest
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
    [JsonPropertyName("asset_report_token")]
    public required string AssetReportToken { get; init; }

    /// <summary>
    /// The <c>auditor_id</c> of the third party with whom you would like to share the Asset Report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auditor_id")]
    public string? AuditorId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
