using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record TransactionsSyncRequestOptions
{
    /// <summary>
    /// Include the raw unparsed transaction description from the financial institution.
    /// </summary>
    [JsonPropertyName("include_original_description")]
    public bool? IncludeOriginalDescription { get; init; } = false;

    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonPropertyName("include_personal_finance_category")]
    public bool? IncludePersonalFinanceCategory { get; init; } = false;

    /// <summary>
    /// Counterparties and extra merchant fields are now returned by default.
    /// </summary>
    [JsonPropertyName("include_logo_and_counterparty_beta")]
    public bool? IncludeLogoAndCounterpartyBeta { get; init; } = false;

    /// <summary>
    /// Indicates which version of the personal finance category taxonomy is being used. <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">View PFCv2 and PFCv1 taxonomies</see>.
    /// <para>
    /// If you enabled Transactions or Enrich before December 3, 2025 you will receive the <c>v1</c> taxonomy by default and may request <c>v2</c> by explicitly setting this field to <c>v2</c> in the request.
    /// </para>
    /// <para>
    /// If you enabled Transactions or Enrich on or after December 3, 2025, you may only receive the <c>v2</c> taxonomy.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category_version")]
    public PersonalFinanceCategoryVersion? PersonalFinanceCategoryVersion { get; init; }

    /// <summary>
    /// This field only applies to calls for Items where the Transactions product has not already been initialized (i.e., by specifying <c>transactions</c> in the <c>products</c>, <c>required_if_supported_products</c>, or <c>optional_products</c> array when calling <c>/link/token/create</c> or by making a previous call to <c>/transactions/sync</c> or <c>/transactions/get</c>). In those cases, the field controls the maximum number of days of transaction history that Plaid will request from the financial institution. The more transaction history is requested, the longer the historical update poll will take. If no value is specified, 90 days of history will be requested by default. In Production, if a value less than 30 is provided, a minimum of 30 days of transaction history will be requested.
    /// <para>
    /// If you are initializing your Items with transactions during the <c>/link/token/create</c> call (e.g. by including <c>transactions</c> in the <c>/link/token/create</c> <c>products</c> array), you must use the <see href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>transactions.days_requested</c></see> field in the <c>/link/token/create</c> request instead of in the <c>/transactions/sync</c> request.
    /// </para>
    /// <para>
    /// If the Item has already been initialized with the Transactions product, this field will have no effect. The maximum amount of transaction history to request on an Item cannot be updated if Transactions has already been added to the Item. To request older transaction history on an Item where Transactions has already been added, you must delete the Item via <c>/item/remove</c> and send the user through Link to create a new Item.
    /// </para>
    /// <para>
    /// Customers using <see href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</see> should request at least 180 days of history for optimal results.
    /// </para>
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; } = 90;

    /// <summary>
    /// If provided, the returned updates and cursor will only reflect the specified account's transactions. Omitting <c>account_id</c> returns updates for all accounts under the Item. Note that specifying an <c>account_id</c> effectively creates a separate incremental update stream -- and therefore a separate cursor -- for that account. If multiple accounts are queried this way, you will maintain multiple cursors, one per <c>account_id</c>.
    /// <para>
    /// If you decide to begin filtering by <c>account_id</c> after using no <c>account_id</c>, start fresh with a null cursor and maintain separate <c>(account_id, cursor)</c> pairs going forward. Do not reuse any previously saved cursors, as this can cause pagination errors or incomplete data.
    /// </para>
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
