using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the total deductions for the pay period
/// </summary>
public record DeductionsTotal
{
    /// <summary>
    /// Raw amount of the deduction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_amount")]
    public double? CurrentAmount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the line item. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the line item. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// The year-to-date total amount of the deductions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ytd_amount")]
    public double? YtdAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
