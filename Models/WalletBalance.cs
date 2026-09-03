using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the e-wallet balance
/// </summary>
public record WalletBalance
{
    /// <summary>
    /// The ISO-4217 currency code of the balance
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The total amount of funds in the account
    /// </summary>
    [JsonPropertyName("current")]
    public required double Current { get; init; }

    /// <summary>
    /// The total amount of funds in the account after subtracting pending debit transaction amounts
    /// </summary>
    [JsonPropertyName("available")]
    public required double Available { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
