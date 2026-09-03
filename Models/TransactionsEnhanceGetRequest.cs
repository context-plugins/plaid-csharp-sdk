using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsEnhanceGetRequest defines the request schema for <c>/beta/transactions/v1/enhance</c>.
/// </summary>
public record TransactionsEnhanceGetRequest
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
    /// The type of account for the requested transactions (<c>depository</c> or <c>credit</c>).
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string AccountType { get; init; }

    /// <summary>
    /// An array of raw transactions to be enhanced.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<ClientProvidedRawTransaction> Transactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
