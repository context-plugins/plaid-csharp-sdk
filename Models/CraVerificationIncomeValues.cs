using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Modeled income values for a given time period.
/// </summary>
public record CraVerificationIncomeValues
{
    /// <summary>
    /// Gross Income modeled from trends of observed transactions.
    /// </summary>
    [JsonPropertyName("gross_income")]
    public required double GrossIncome { get; init; }

    /// <summary>
    /// Net Income estimated from observed transactions.
    /// </summary>
    [JsonPropertyName("net_income")]
    public required double NetIncome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
