using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing both a breakdown of earnings on a paystub and the total earnings.
/// </summary>
public record Earnings
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtotals")]
    public IReadOnlyList<EarningsTotal>? Subtotals { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totals")]
    public IReadOnlyList<EarningsTotal>? Totals { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("breakdown")]
    public IReadOnlyList<EarningsBreakdown>? Breakdown { get; init; }

    /// <summary>
    /// An object representing both the current pay period and year to date amount for an earning category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public EarningsTotal? Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
