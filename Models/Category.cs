using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information describing a transaction category
/// </summary>
public record Category
{
    /// <summary>
    /// An identifying number for the category. <c>category_id</c> is a Plaid-specific identifier and does not necessarily correspond to merchant category codes.
    /// </summary>
    [JsonPropertyName("category_id")]
    public required string CategoryId { get; init; }

    /// <summary>
    /// <c>place</c> for physical transactions or <c>special</c> for other transactions such as bank charges.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; init; }

    /// <summary>
    /// A hierarchical array of the categories to which this <c>category_id</c> belongs.
    /// </summary>
    [JsonPropertyName("hierarchy")]
    public required IReadOnlyList<string> Hierarchy { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
