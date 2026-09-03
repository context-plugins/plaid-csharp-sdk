using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsSyncRequest defines the request schema for <c>/transactions/sync</c>
/// </summary>
public record TransactionsSyncRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The cursor value represents the last update requested. Providing it will cause the response to only return changes after this update.
    /// If omitted, the entire history of updates will be returned, starting with the first-added transactions on the Item. The cursor also accepts the special value of <c>"now"</c>, which can be used to fast-forward the cursor as part of migrating an existing Item from <c>/transactions/get</c> to <c>/transactions/sync</c>. For more information, see the <see href="https://plaid.com/docs/transactions/sync-migration/">Transactions sync migration guide</see>. Note that using the <c>"now"</c> value is not supported for any use case other than migrating existing Items from <c>/transactions/get</c>.
    /// <para>
    /// The upper-bound length of this cursor is 256 characters of base64.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of transaction updates to fetch.
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public TransactionsSyncRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
