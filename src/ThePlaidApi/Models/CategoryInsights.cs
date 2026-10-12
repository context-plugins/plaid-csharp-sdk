using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights on a user's top personal finance categories.
/// </summary>
public record CategoryInsights
{
    /// <summary>
    /// List of insights of top primary personal finance categories ranked by outflow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_category_insights")]
    public IReadOnlyList<CategoryInsightDetails>? PrimaryCategoryInsights { get; init; }

    /// <summary>
    /// List of insights of top detailed personal finance categories ranked by outflow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detailed_category_insights")]
    public IReadOnlyList<CategoryInsightDetails>? DetailedCategoryInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
