using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object with the deduction information found on a paystub.
/// </summary>
public record Deductions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtotals")]
    public IReadOnlyList<Total>? Subtotals { get; init; }

    [JsonPropertyName("breakdown")]
    public required IReadOnlyList<DeductionsBreakdown> Breakdown { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totals")]
    public IReadOnlyList<Total>? Totals { get; init; }

    /// <summary>
    /// An object representing the total deductions for the pay period
    /// </summary>
    [JsonPropertyName("total")]
    public required DeductionsTotal Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
