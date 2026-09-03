using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletListRequest defines the request schema for <c>/wallet/list</c>
/// </summary>
public record WalletListRequest
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
    /// An ISO-4217 currency code, used with e-wallets and transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public IsoCurrencyCode? IsoCurrencyCode { get; init; }

    /// <summary>
    /// A base64 value representing the latest e-wallet that has already been requested. Set this to <c>next_cursor</c> received from the previous <c>/wallet/list</c> request. If provided, the response will only contain e-wallets created before that e-wallet. If omitted, the response will contain e-wallets starting from the most recent, and in descending order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(1024)]
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of e-wallets to fetch
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(20)]
    public int? Count { get; init; } = 10;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
