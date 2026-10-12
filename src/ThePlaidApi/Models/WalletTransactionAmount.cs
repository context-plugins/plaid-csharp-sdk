using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The amount and currency of a transaction
/// </summary>
public record WalletTransactionAmount
{
    /// <summary>
    /// An ISO-4217 currency code, used with e-wallets and transactions.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required IsoCurrencyCode IsoCurrencyCode { get; init; }

    /// <summary>
    /// The amount of the transaction. Must contain at most two digits of precision e.g. <c>1.23</c>.
    /// </summary>
    [JsonPropertyName("value")]
    [Minimum(0.01)]
    public required double Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
