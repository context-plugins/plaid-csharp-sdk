using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A client-provided transaction for Plaid to enhance.
/// </summary>
public record ClientProvidedRawTransaction
{
    /// <summary>
    /// A unique ID for the transaction used to help you tie data back to your systems.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The raw description of the transaction.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The value of the transaction with direction. (NOTE: this will affect enrichment results, so directions are important).
    ///   Negative (-) for credits (e.g., incoming transfers, refunds)
    ///   Positive (+) for debits (e.g., purchases, fees, outgoing transfers)
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction e.g. USD.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
