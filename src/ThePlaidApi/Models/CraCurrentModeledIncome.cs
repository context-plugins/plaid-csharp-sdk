using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Modeled estimate of current income based on recently observed income transactions.
/// </summary>
public record CraCurrentModeledIncome
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
