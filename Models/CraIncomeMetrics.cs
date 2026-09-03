using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Modeled income metrics for a given income stream or user summary.
/// </summary>
public record CraIncomeMetrics
{
    /// <summary>
    /// Modeled estimate of current income based on recently observed income transactions.
    /// </summary>
    [JsonPropertyName("current")]
    public required CraCurrentModeledIncome? Current { get; init; }

    /// <summary>
    /// Forward-looking modeled estimate of income based on recent income transactions and trends in active streams.
    /// </summary>
    [JsonPropertyName("projected")]
    public required CraProjectedModeledIncome? Projected { get; init; }

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
