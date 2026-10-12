using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of a transaction
/// </summary>
public record TransactionBase
{
    /// <summary>
    /// The ID of the account in which this transaction occurred.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The settled value of the transaction, denominated in the transaction's currency, as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>. For all products except Income: Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative. For Income endpoints, values are positive when representing income.
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
    /// A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// <para>
    /// All Transactions implementations are recommended to use the new <c>personal_finance_category</c> instead of <c>category</c>, as it provides greater accuracy and more meaningful categorization.
    /// </para>
    /// <para>
    /// If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public IReadOnlyList<string>? Category { get; init; }

    /// <summary>
    /// The ID of the category to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// <para>
    /// All Transactions implementations are recommended to use the new <c>personal_finance_category</c> instead of <c>category</c>, as it provides greater accuracy and more meaningful categorization.
    /// </para>
    /// <para>
    /// If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; init; }

    /// <summary>
    /// The check number of the transaction. This field is only populated for check transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

    /// <summary>
    /// For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DD</c> ). To receive information about the date that a posted transaction was initiated, see the <c>authorized_date</c> field.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// A representation of where a transaction took place. Location data is provided only for transactions at physical locations, not for online transactions. Location data availability depends primarily on the merchant and is most likely to be populated for transactions at large retail chains; small, local businesses are less likely to have location data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public TransactionLocation? Location { get; init; }

    /// <summary>
    /// The merchant name or transaction description.
    /// <para>
    /// Note: While Plaid does not currently plan to remove this field, it is a legacy field that is not actively maintained. Use <c>merchant_name</c> instead for the merchant name.
    /// </para>
    /// <para>
    /// If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/sync</c> or <c>/transactions/get</c>, this field will always appear. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The merchant name, as enriched by Plaid from the <c>name</c> field. This is typically a more human-readable version of the merchant counterparty in the transaction. For some bank transactions (such as checks or account transfers) where there is no meaningful merchant name, this value will be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_name")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// The string returned by the financial institution to describe the transaction. For transactions returned by <c>/transactions/sync</c> or <c>/transactions/get</c>, this field will only be included if the client has set <c>options.include_original_description</c> to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_description")]
    public string? OriginalDescription { get; init; }

    /// <summary>
    /// Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.
    /// <para>
    /// If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/sync</c> or <c>/transactions/get</c>, the <c>payment_meta</c> key will always appear, but no data elements are guaranteed. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_meta")]
    public PaymentMeta? PaymentMeta { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled. Not all institutions provide pending transactions.
    /// </summary>
    [JsonPropertyName("pending")]
    public required bool Pending { get; init; }

    /// <summary>
    /// The ID of a posted transaction's associated pending transaction, where applicable. Not all institutions provide pending transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending_transaction_id")]
    public string? PendingTransactionId { get; init; }

    /// <summary>
    /// This field is not typically populated and only relevant when dealing with sub-accounts. A sub-account most commonly exists in cases where a single account is linked to multiple cards, each with its own card number and card holder name; each card will be considered a sub-account. If the account does have sub-accounts, this field will typically be some combination of the sub-account owner's name and/or the sub-account mask. The format of this field is not standardized and will vary based on institution.
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
    /// Please use the <c>payment_channel</c> field, <c>transaction_type</c> will be deprecated in the future.
    /// <para>
    /// <c>digital:</c> transactions that took place online.
    /// </para>
    /// <para>
    /// <c>place:</c> transactions that were made at a physical location.
    /// </para>
    /// <para>
    /// <c>special:</c> transactions that relate to banks, e.g. fees or deposits.
    /// </para>
    /// <para>
    /// <c>unresolved:</c> transactions that do not fit into the other three types.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_type")]
    public TransactionType? TransactionType { get; init; }

    /// <summary>
    /// The URL of a logo associated with this transaction, if available. The logo will always be a 100×100 pixel PNG file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_url")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The website associated with this transaction, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
