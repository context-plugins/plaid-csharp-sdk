using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AccountsGetRequest defines the request schema for <c>/accounts/get</c>
/// </summary>
public record AccountsGetRequest
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
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// An optional object to filter <c>/accounts/get</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public AccountsGetRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
