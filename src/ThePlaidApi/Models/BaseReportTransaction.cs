using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A transaction on the Base Report
/// </summary>
public record BaseReportTransaction
{
    /// <summary>
    /// The ID of the account in which this transaction occurred.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The settled value of the transaction, denominated in the transaction's currency, as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
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

    /// <summary>
    /// The merchant name or transaction description.
    /// <para>
    /// Note: This is a legacy field that is not actively maintained. Use <c>merchant_name</c> instead for the merchant name.
    /// </para>
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
    /// Information describing the intent of the transaction. Most relevant for credit use cases, but not limited to such use cases.
    /// <para>
    /// See the <see href="https://plaid.com/documents/credit-category-taxonomy.csv"><c>taxonomy csv file</c></see> for a full list of credit categories.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_category")]
    public CreditCategory? CreditCategory { get; init; }

    /// <summary>
    /// The check number of the transaction. This field is only populated for check transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

    /// <summary>
    /// For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DD</c> ).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// The date on which the transaction took place, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_transacted")]
    public string? DateTransacted { get; init; }

    /// <summary>
    /// A representation of where a transaction took place. Location data is provided only for transactions at physical locations, not for online transactions. Location data availability depends primarily on the merchant and is most likely to be populated for transactions at large retail chains; small, local businesses are less likely to have location data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public TransactionLocation? Location { get; init; }

    /// <summary>
    /// The merchant name, as enriched by Plaid from the <c>name</c> field. This is typically a more human-readable version of the merchant counterparty in the transaction. For some bank transactions (such as checks or account transfers) where there is no meaningful merchant name, this value will be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_name")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.
    /// </summary>
    [JsonPropertyName("pending")]
    public required bool Pending { get; init; }

    /// <summary>
    /// The name of the account owner. This field is not typically populated and only relevant when dealing with sub-accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_owner")]
    public string? AccountOwner { get; init; }

    /// <summary>
    /// The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// <c>digital:</c> transactions that took place online.
    /// <para>
    /// <c>place:</c> transactions that were made at a physical location.
    /// </para>
    /// <para>
    /// <c>special:</c> transactions that relate to banks, e.g. fees or deposits.
    /// </para>
    /// <para>
    /// <c>unresolved:</c> transactions that do not fit into the other types.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_type")]
    public BaseReportTransactionType? TransactionType { get; init; }

    /// <summary>
    /// A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public IReadOnlyList<string>? Category { get; init; }

    /// <summary>
    /// The ID of the category to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category")]
    public PersonalFinanceCategory? PersonalFinanceCategory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
