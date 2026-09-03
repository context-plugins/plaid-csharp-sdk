using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Field containing the data used in determining the outcome of a synthetic fraud risk check.
/// </summary>
public record SyntheticFraud
{
    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonPropertyName("risk_level")]
    public required RiskLevel RiskLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
