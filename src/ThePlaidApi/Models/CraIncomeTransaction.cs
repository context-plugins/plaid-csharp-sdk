using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The transaction data for an income stream.
/// </summary>
public record CraIncomeTransaction
{
    /// <summary>
    /// The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.
    /// <para>
    /// If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.
    /// </para>
    /// <para>
    /// Like all Plaid identifiers, the <c>account_id</c> is case sensitive.
    /// </para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The settled value of the transaction, denominated in the transaction's currency as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>.
    /// Positive values when money moves out of the account; negative values when money moves in.
    /// For example, credit card purchases are positive; credit card payment, direct deposits, and refunds are negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted.
    /// Both dates are returned in an ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// The string returned by the financial institution to describe the transaction.
    /// </summary>
    [JsonPropertyName("original_description")]
    public required string OriginalDescription { get; init; }

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

    /// <summary>
    /// Metadata on whether this income transaction is an outlier.
    /// </summary>
    [JsonPropertyName("outlier")]
    public required CraIncomeTransactionOutlier Outlier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
