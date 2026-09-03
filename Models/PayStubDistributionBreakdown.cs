using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the accounts that the payment was distributed to.
/// </summary>
public record PayStubDistributionBreakdown
{
    /// <summary>
    /// Name of the account for the given distribution.
    /// </summary>
    [JsonPropertyName("account_name")]
    public required string? AccountName { get; init; }

    /// <summary>
    /// The name of the bank that the payment is being deposited to.
    /// </summary>
    [JsonPropertyName("bank_name")]
    public required string? BankName { get; init; }

    /// <summary>
    /// The amount distributed to this account.
    /// </summary>
    [JsonPropertyName("current_amount")]
    public required double? CurrentAmount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the net pay. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number.
    /// </summary>
    [JsonPropertyName("mask")]
    public required string? Mask { get; init; }

    /// <summary>
    /// Type of the account that the paystub was sent to (e.g. 'checking').
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the net pay. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
