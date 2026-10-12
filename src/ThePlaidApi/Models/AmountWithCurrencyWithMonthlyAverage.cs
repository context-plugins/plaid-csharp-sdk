using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents an amount and a monthly average
/// </summary>
public record AmountWithCurrencyWithMonthlyAverage
{
    /// <summary>
    /// If the parent object represents a category of transactions, such as <c>total_amount</c>, <c>transfers_in</c>, <c>total_income</c>, etc. the <c>amount</c> represents the sum of all of the transactions in the group.
    /// <para>
    /// If the parent object is <c>cash_flow</c>, the <c>amount</c> represents the total value of all the inflows minus all the outflows across all the accounts in the report in the given time window.
    /// </para>
    /// <para>
    /// If the parent object is <c>minimum_balance</c>, the <c>amount</c> represents the lowest balance of the account during the given time window.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the amount. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the amount. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unofficial_currency_code")]
    public string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
