using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletTransactionListRequest defines the request schema for <c>/wallet/transaction/list</c>
/// </summary>
public record WalletTransactionListRequest
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
    /// The ID of the e-wallet to fetch transactions from
    /// </summary>
    [JsonPropertyName("wallet_id")]
    [MinLength(1)]
    public required string WalletId { get; init; }

    /// <summary>
    /// A value representing the latest transaction to be included in the response. Set this from <c>next_cursor</c> received in the previous <c>/wallet/transaction/list</c> request. If provided, the response will only contain that transaction and transactions created before it. If omitted, the response will contain transactions starting from the most recent, and in descending order by the <c>created_at</c> time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(256)]
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of transactions to fetch
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Count { get; init; } = 10;

    /// <summary>
    /// Additional wallet transaction options
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public WalletTransactionListRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
