using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information describing the intent of the transaction. Most relevant for credit use cases, but not limited to such use cases.
/// <para>
/// See the <see href="https://plaid.com/documents/credit-category-taxonomy.csv"><c>taxonomy csv file</c></see> for a full list of credit categories.
/// </para>
/// </summary>
public record CreditCategory
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
