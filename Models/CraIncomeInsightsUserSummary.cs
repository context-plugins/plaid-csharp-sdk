using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Aggregated summary of all income streams for this user.
/// </summary>
public record CraIncomeInsightsUserSummary
{
    /// <summary>
    /// List of a user's aggregated income metrics for each currency.
    /// </summary>
    [JsonPropertyName("income_metrics")]
    public required IReadOnlyList<CraIncomeMetrics> IncomeMetrics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
