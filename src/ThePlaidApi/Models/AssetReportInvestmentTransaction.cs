using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A transaction within an investment account.
/// </summary>
public record AssetReportInvestmentTransaction
{
    /// <summary>
    /// The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the <c>investment_transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("investment_transaction_id")]
    public required string InvestmentTransactionId { get; init; }

    /// <summary>
    /// The <c>account_id</c> of the account against which this transaction posted.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The <c>security_id</c> to which this transaction is related.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string? SecurityId { get; init; }

    /// <summary>
    /// The <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> posting date for the transaction.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// The institution's description of the transaction.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The number of units of the security involved in this transaction. Positive for buy transactions; negative for sell transactions.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// The total quantity of vested assets held, as reported by the financial institution. Vested assets are only associated with <see href="https://plaid.com/docs/api/products/investments/#investments-holdings-get-response-securities-type">equities</see>.
    /// </summary>
    [JsonPropertyName("vested_quantity")]
    public required double VestedQuantity { get; init; }

    /// <summary>
    /// The value of the vested holdings as reported by the institution.
    /// </summary>
    [JsonPropertyName("vested_value")]
    public required double VestedValue { get; init; }

    /// <summary>
    /// The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities. For transactions representing a simultaneous cash contribution and purchase of a security, the portion of the transaction representing the purchase takes precedence, and the <c>amount</c> is represented as positive.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The price of the security at which this transaction occurred.
    /// </summary>
    [JsonPropertyName("price")]
    public required double Price { get; init; }

    /// <summary>
    /// The combined value of all fees applied to this transaction
    /// </summary>
    [JsonPropertyName("fees")]
    public required double? Fees { get; init; }

    /// <summary>
    /// Value is one of the following:
    /// <c>buy</c>: Buying an investment
    /// <c>sell</c>: Selling an investment
    /// <c>cancel</c>: A cancellation of a pending transaction
    /// <c>cash</c>: Activity that modifies a cash position
    /// <c>fee</c>: A fee on the account
    /// <c>transfer</c>: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
    /// <para>
    /// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required InvestmentTransactionType Type { get; init; }

    /// <summary>
    /// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
    /// </summary>
    [JsonPropertyName("subtype")]
    public required InvestmentTransactionSubtype Subtype { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the transaction. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
