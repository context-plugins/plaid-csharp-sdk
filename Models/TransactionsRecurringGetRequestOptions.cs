using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record TransactionsRecurringGetRequestOptions
{
    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonPropertyName("include_personal_finance_category")]
    public bool? IncludePersonalFinanceCategory { get; init; } = false;

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
