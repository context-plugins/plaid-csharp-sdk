using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditRelayGetRequest defines the request schema for <c>/credit/relay/get</c>
/// </summary>
public record CreditRelayGetRequest
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
    /// The <c>relay_token</c> granting access to the report you would like to get.
    /// </summary>
    [JsonPropertyName("relay_token")]
    public required string RelayToken { get; init; }

    /// <summary>
    /// The report type. It can be <c>asset</c>. Income report types are not yet supported.
    /// </summary>
    [JsonPropertyName("report_type")]
    public required ReportType ReportType { get; init; }

    /// <summary>
    /// <c>true</c> if you would like to retrieve the Asset Report with Insights, <c>false</c> otherwise. This field defaults to <c>false</c> if omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_insights")]
    public bool? IncludeInsights { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
