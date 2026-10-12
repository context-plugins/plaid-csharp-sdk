using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing both the current pay period and year to date amount for an earning category.
/// </summary>
public record PayStubEarningsTotal
{
    /// <summary>
    /// Total amount of the earnings for this pay period.
    /// </summary>
    [JsonPropertyName("current_amount")]
    public required double? CurrentAmount { get; init; }

    /// <summary>
    /// Total number of hours worked for this pay period.
    /// </summary>
    [JsonPropertyName("hours")]
    public required double? Hours { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the line item. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the line item. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// The total year-to-date amount of the earnings.
    /// </summary>
    [JsonPropertyName("ytd_amount")]
    public required double? YtdAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
