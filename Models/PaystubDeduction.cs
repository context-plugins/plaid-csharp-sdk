using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Deduction on the paystub
/// </summary>
public record PaystubDeduction
{
    /// <summary>
    /// The type of the deduction, as provided on the paystub. For example: <c>"401(k)"</c>, <c>"FICA MED TAX"</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    /// <summary>
    /// <c>true</c> if the deduction is pre-tax; <c>false</c> otherwise.
    /// </summary>
    [JsonPropertyName("is_pretax")]
    public required bool? IsPretax { get; init; }

    /// <summary>
    /// The amount of the deduction.
    /// </summary>
    [JsonPropertyName("total")]
    public required double? Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
