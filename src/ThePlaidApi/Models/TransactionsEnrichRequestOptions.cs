using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request.
/// </summary>
public record TransactionsEnrichRequestOptions
{
    /// <summary>
    /// Include <c>legacy_category</c> and <c>legacy_category_id</c> in the response (in addition to the default <c>personal_finance_category</c>).
    /// <para>
    /// Categories are based on Plaid's legacy taxonomy. For a full list of legacy categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_legacy_category")]
    public bool? IncludeLegacyCategory { get; init; } = false;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
