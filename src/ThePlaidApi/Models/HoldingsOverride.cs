using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specify the holdings on the account.
/// </summary>
public record HoldingsOverride
{
    /// <summary>
    /// The last price given by the institution for this security
    /// </summary>
    [JsonPropertyName("institution_price")]
    public required double InstitutionPrice { get; init; }

    /// <summary>
    /// The date at which <c>institution_price</c> was current. Must be formatted as an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_price_as_of")]
    public DateTimeOffset? InstitutionPriceAsOf { get; init; }

    /// <summary>
    /// The total cost basis of the holding (e.g., the total amount spent to acquire all assets currently in the holding).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cost_basis")]
    public double? CostBasis { get; init; }

    /// <summary>
    /// The total quantity of the asset held, as reported by the financial institution.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// Either a valid <c>iso_currency_code</c> or <c>unofficial_currency_code</c>
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (<c>ticker_symbol</c>, <c>cusip</c>, or <c>isin</c>) are required.
    /// </summary>
    [JsonPropertyName("security")]
    public required SecurityOverride Security { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
