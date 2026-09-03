using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The transactions data for the end user's income source(s).
/// </summary>
public record CraBankIncomeTransaction
{
    /// <summary>
    /// The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

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
    /// The merchant name or transaction description. This is a legacy field that is no longer maintained. For merchant name, use the <c>merchant_name</c> field; for description, use the <c>original_description</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The string returned by the financial institution to describe the transaction.
    /// </summary>
    [JsonPropertyName("original_description")]
    public required string? OriginalDescription { get; init; }

    /// <summary>
    /// When true, identifies the transaction as pending or unsettled.
    /// Pending transaction details (name, type, amount, category ID) may change before they are settled.
    /// </summary>
    [JsonPropertyName("pending")]
    public required bool Pending { get; init; }

    /// <summary>
    /// The check number of the transaction. This field is only populated for check transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

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
    /// The type of bonus that this transaction represents, if it is a bonus.
    /// <c>BONUS_INCLUDED</c>: Bonus is included in this transaction along with the normal pay
    /// <c>BONUS_ONLY</c>: This transaction is a standalone bonus
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bonus_type")]
    public CraBankIncomeBonusType? BonusType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
