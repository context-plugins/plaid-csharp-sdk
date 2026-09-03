using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights object for categories.
/// </summary>
public record CategoryInsightDetails
{
    /// <summary>
    /// Category name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The number of transactions associated with this category.
    /// </summary>
    [JsonPropertyName("transaction_count")]
    public required int TransactionCount { get; init; }

    /// <summary>
    /// Sum of outflow amounts.
    /// </summary>
    [JsonPropertyName("total_outflows")]
    public required double TotalOutflows { get; init; }

    /// <summary>
    /// Sum of inflow amounts.
    /// </summary>
    [JsonPropertyName("total_inflows")]
    public required double TotalInflows { get; init; }

    /// <summary>
    /// The most common counterparties associated with this category sorted by outflow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_counterparties")]
    public IReadOnlyList<string>? TopCounterparties { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
