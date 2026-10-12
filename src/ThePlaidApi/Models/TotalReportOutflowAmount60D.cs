using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Total amount of credit transactions out of the report's accounts in the last 60 days. This field only takes into account USD transactions from the accounts.
/// </summary>
public record TotalReportOutflowAmount60D
{
    /// <summary>
    /// Value of amount with up to 2 decimal places.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The ISO 4217 currency code of the amount or balance.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.
    /// Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
