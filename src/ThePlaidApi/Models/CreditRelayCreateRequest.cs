using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditRelayCreateRequest defines the request schema for <c>/credit/relay/create</c>
/// </summary>
public record CreditRelayCreateRequest
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
    /// List of report token strings, with at most one token of each report type. Currently only Asset Report token is supported.
    /// </summary>
    [JsonPropertyName("report_tokens")]
    public required IReadOnlyList<string> ReportTokens { get; init; }

    /// <summary>
    /// The <c>secondary_client_id</c> is the client id of the third party with whom you would like to share the relay token.
    /// </summary>
    [JsonPropertyName("secondary_client_id")]
    public required string SecondaryClientId { get; init; }

    /// <summary>
    /// URL to which Plaid will send webhooks when the Secondary Client successfully retrieves an Asset Report by calling <c>/credit/relay/get</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
