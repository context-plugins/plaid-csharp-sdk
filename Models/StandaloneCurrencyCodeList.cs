using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The following currency codes are supported by Plaid.
/// </summary>
public record StandaloneCurrencyCodeList
{
    /// <summary>
    /// Plaid supports all ISO 4217 currency codes.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// List of unofficial currency codes
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required UnofficialCurrencyCodeList UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
