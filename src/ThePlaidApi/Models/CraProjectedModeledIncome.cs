using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Forward-looking modeled estimate of income based on recent income transactions and trends in active streams.
/// </summary>
public record CraProjectedModeledIncome
{
    /// <summary>
    /// Modeled estimate of the monthly income.
    /// </summary>
    [JsonPropertyName("monthly")]
    public required CraMonthlyIncomeValues Monthly { get; init; }

    /// <summary>
    /// Modeled estimate of the annual income.
    /// </summary>
    [JsonPropertyName("annual")]
    public required CraAnnualIncomeValues Annual { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
