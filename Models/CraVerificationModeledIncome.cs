using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Modeled estimate of current income based on recently observed income transactions.
/// </summary>
public record CraVerificationModeledIncome
{
    /// <summary>
    /// Modeled income values for a given time period.
    /// </summary>
    [JsonPropertyName("monthly")]
    public required CraVerificationIncomeValues Monthly { get; init; }

    /// <summary>
    /// Modeled income values for a given time period.
    /// </summary>
    [JsonPropertyName("annual")]
    public required CraVerificationIncomeValues Annual { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
