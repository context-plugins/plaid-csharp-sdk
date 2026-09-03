using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specify the list of investments transactions on the account.
/// </summary>
public record InvestmentsTransactionsOverride
{
    /// <summary>
    /// Posting date for the transaction. Must be formatted as an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> date.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// The institution's description of the transaction.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The number of units of the security involved in this transaction. Must be positive if the type is a buy and negative if the type is a sell.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// The price of the security at which this transaction occurred.
    /// </summary>
    [JsonPropertyName("price")]
    public required double Price { get; init; }

    /// <summary>
    /// The combined value of all fees applied to this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fees")]
    public double? Fees { get; init; }

    /// <summary>
    /// The type of the investment transaction. Possible values are:
    /// <c>buy</c>: Buying an investment
    /// <c>sell</c>: Selling an investment
    /// <c>cash</c>: Activity that modifies a cash position
    /// <c>fee</c>: A fee on the account
    /// <c>transfer</c>: Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Either a valid <c>iso_currency_code</c> or <c>unofficial_currency_code</c>
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (<c>ticker_symbol</c>, <c>cusip</c>, or <c>isin</c>) are required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("security")]
    public SecurityOverride? Security { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
