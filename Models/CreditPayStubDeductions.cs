using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object with the deduction information found on a pay stub.
/// </summary>
public record CreditPayStubDeductions
{
    [JsonPropertyName("breakdown")]
    public required IReadOnlyList<PayStubDeductionsBreakdown> Breakdown { get; init; }

    /// <summary>
    /// An object representing the total deductions for the pay period
    /// </summary>
    [JsonPropertyName("total")]
    public required PayStubDeductionsTotal Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
