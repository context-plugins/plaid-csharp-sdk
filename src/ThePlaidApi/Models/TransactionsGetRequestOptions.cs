using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record TransactionsGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// The number of transactions to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// The number of transactions to skip. The default value is 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    [Minimum(0)]
    public int? Offset { get; init; } = 0;

    /// <summary>
    /// Include the raw unparsed transaction description from the financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_original_description")]
    public bool? IncludeOriginalDescription { get; init; } = false;

    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_personal_finance_category_beta")]
    public bool? IncludePersonalFinanceCategoryBeta { get; init; } = false;

    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_personal_finance_category")]
    public bool? IncludePersonalFinanceCategory { get; init; } = false;

    /// <summary>
    /// Counterparties and extra merchant fields are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
    /// This field only applies to calls for Items where the Transactions product has not already been initialized (i.e. by specifying <c>transactions</c> in the <c>products</c>, <c>optional_products</c>, or <c>required_if_supported_products</c> array when calling <c>/link/token/create</c> or by making a previous call to <c>/transactions/sync</c> or <c>/transactions/get</c>). In those cases, the field controls the maximum number of days of transaction history that Plaid will request from the financial institution. The more transaction history is requested, the longer the historical update poll will take. If no value is specified, 90 days of history will be requested by default. In Production, if a value under 30 is provided, a minimum of 30 days of history will be requested.
    /// <para>
    /// If you are initializing your Items with transactions during the <c>/link/token/create</c> call (e.g. by including <c>transactions</c> in the <c>/link/token/create</c> <c>products</c> array), you must use the <see href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>transactions.days_requested</c></see> field in the <c>/link/token/create</c> request instead of in the <c>/transactions/get</c> request.
    /// </para>
    /// <para>
    /// If the Item has already been initialized with the Transactions product, this field will have no effect. The maximum amount of transaction history to request on an Item cannot be updated if Transactions has already been added to the Item. To request older transaction history on an Item where Transactions has already been added, you must delete the Item via <c>/item/remove</c> and send the user through Link to create a new Item.
    /// </para>
    /// <para>
    /// Customers using <see href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</see> should request at least 180 days of history for optimal results.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; } = 90;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
