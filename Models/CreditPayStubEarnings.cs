using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing both a breakdown of earnings on a pay stub and the total earnings.
/// </summary>
public record CreditPayStubEarnings
{
    [JsonPropertyName("breakdown")]
    public required IReadOnlyList<PayStubEarningsBreakdown> Breakdown { get; init; }

    /// <summary>
    /// An object representing both the current pay period and year to date amount for an earning category.
    /// </summary>
    [JsonPropertyName("total")]
    public required PayStubEarningsTotal Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
