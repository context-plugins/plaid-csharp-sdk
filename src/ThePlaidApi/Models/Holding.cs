using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A securities holding at an institution.
/// </summary>
public record Holding
{
    /// <summary>
    /// The Plaid <c>account_id</c> associated with the holding.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The Plaid <c>security_id</c> associated with the holding. Security data is not specific to a user's account; any user who held the same security at the same financial institution at the same time would have identical security data. The <c>security_id</c> for the same security will typically be the same across different institutions, but this is not guaranteed. The <c>security_id</c> does not typically change, but may change if inherent details of the security change due to a corporate action, for example, in the event of a ticker symbol change or CUSIP change.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string SecurityId { get; init; }

    /// <summary>
    /// The last price given by the institution for this security.
    /// </summary>
    [JsonPropertyName("institution_price")]
    public required double InstitutionPrice { get; init; }

    /// <summary>
    /// The date at which <c>institution_price</c> was current.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_price_as_of")]
    public DateTimeOffset? InstitutionPriceAsOf { get; init; }

    /// <summary>
    /// Date and time at which <c>institution_price</c> was current, in ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// <para>
    /// This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_price_datetime")]
    public DateTimeOffset? InstitutionPriceDatetime { get; init; }

    /// <summary>
    /// The value of the holding, as reported by the institution.
    /// </summary>
    [JsonPropertyName("institution_value")]
    public required double InstitutionValue { get; init; }

    /// <summary>
    /// The total cost basis of the holding (e.g., the total amount spent to acquire all assets currently in the holding).
    /// </summary>
    [JsonPropertyName("cost_basis")]
    public required double? CostBasis { get; init; }

    /// <summary>
    /// The total quantity of the asset held, as reported by the financial institution. If the security is an option, <c>quantity</c> will reflect the total number of options (typically the number of contracts multiplied by 100), not the number of contracts.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the holding. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the holding. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// The total quantity of vested assets held, as reported by the financial institution. Vested assets are only associated with <see href="https://plaid.com/docs/api/products/investments/#investments-holdings-get-response-securities-type">equities</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vested_quantity")]
    public double? VestedQuantity { get; init; }

    /// <summary>
    /// The value of the vested holdings as reported by the institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vested_value")]
    public double? VestedValue { get; init; }

    /// <summary>
    /// Per-lot acquisition data for this holding. An empty array indicates the institution does not provide lot-level data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_lots")]
    public IReadOnlyList<HoldingTaxLot>? TaxLots { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
