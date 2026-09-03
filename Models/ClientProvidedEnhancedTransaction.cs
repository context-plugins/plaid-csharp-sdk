using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A client-provided transaction that Plaid has enhanced.
/// </summary>
public record ClientProvidedEnhancedTransaction
{
    /// <summary>
    /// Unique transaction identifier to tie transactions back to clients' systems.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The raw description of the transaction.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The value of the transaction, denominated in the account's currency, as stated in <c>iso_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// A grouping of the Plaid produced transaction enhancement fields.
    /// </summary>
    [JsonPropertyName("enhancements")]
    public required Enhancements Enhancements { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
