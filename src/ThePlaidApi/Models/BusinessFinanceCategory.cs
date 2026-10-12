using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information describing the intent of the transaction. Most relevant for business finance use cases, but not limited to such use cases.
/// </summary>
public record BusinessFinanceCategory
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
