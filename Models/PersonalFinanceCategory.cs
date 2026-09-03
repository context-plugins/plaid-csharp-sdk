using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.
/// <para>
/// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy CSV file</see> for a full list of personal finance categories. If you are migrating to personal finance categories from the legacy categories, also refer to the <see href="https://plaid.com/docs/transactions/pfc-migration/">migration guide</see>.
/// </para>
/// </summary>
public record PersonalFinanceCategory
{
    /// <summary>
    /// A high level category that communicates the broad category of the transaction.
    /// </summary>
    [JsonPropertyName("primary")]
    public required string Primary { get; init; }

    /// <summary>
    /// A granular category conveying the transaction's intent. This field can also be used as a unique identifier for the category.
    /// </summary>
    [JsonPropertyName("detailed")]
    public required string Detailed { get; init; }

    /// <summary>
    /// A description of how confident we are that the provided categories accurately describe the transaction intent.
    /// <para>
    /// <c>VERY_HIGH</c>: We are more than 98% confident that this category reflects the intent of the transaction.
    /// <c>HIGH</c>: We are more than 90% confident that this category reflects the intent of the transaction.
    /// <c>MEDIUM</c>: We are moderately confident that this category reflects the intent of the transaction.
    /// <c>LOW</c>: This category may reflect the intent, but there may be other categories that are more accurate.
    /// <c>UNKNOWN</c>: We don't know the confidence level for this category.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_level")]
    public string? ConfidenceLevel { get; init; }

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
    [JsonPropertyName("version")]
    public PersonalFinanceCategoryVersion? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
