using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object with the deduction information found on a paystub.
/// </summary>
public record PaystubOverrideDeductions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("breakdown")]
    public IReadOnlyList<PaystubOverrideDeductionsBreakdown>? Breakdown { get; init; }

    /// <summary>
    /// An object representing the total deductions for the pay period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public PaystubOverrideDeductionsTotal? Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
