using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The income category for a given stream. The streams returned in the response will be filtered based on these primary and secondary income categories.
/// <para>
/// See the <see href="https://plaid.com/documents/income-v2-category-taxonomy.csv">Income V2 Category Taxonomy</see> for a full list of income categories.
/// </para>
/// </summary>
public record CraIncomeCategory
{
    /// <summary>
    /// A high level category that communicates the broad category of the stream.
    /// </summary>
    [JsonPropertyName("primary")]
    public required string Primary { get; init; }

    /// <summary>
    /// A granular category conveying the stream's intent.
    /// </summary>
    [JsonPropertyName("secondary")]
    public required string Secondary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
