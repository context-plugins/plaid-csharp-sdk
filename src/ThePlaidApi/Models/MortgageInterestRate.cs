using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing metadata about the interest rate for the mortgage.
/// </summary>
public record MortgageInterestRate
{
    /// <summary>
    /// Percentage value (interest rate of current mortgage, not APR) of interest payable on a loan.
    /// </summary>
    [JsonPropertyName("percentage")]
    public required double? Percentage { get; init; }

    /// <summary>
    /// The type of interest charged (fixed or variable).
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
