using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsEnrichRequest defines the request schema for <c>/transactions/enrich</c>.
/// </summary>
public record TransactionsEnrichRequest
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
    /// The account type for the requested transactions (either <c>depository</c> or <c>credit</c>).
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string AccountType { get; init; }

    /// <summary>
    /// An array of transaction objects to be enriched by Plaid. Maximum of 100 transactions per request.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<ClientProvidedTransaction> Transactions { get; init; }

    /// <summary>
    /// An optional object to be used with the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public TransactionsEnrichRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
