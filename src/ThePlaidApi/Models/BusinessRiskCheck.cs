using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Results from the business risk assessment check
/// </summary>
public record BusinessRiskCheck
{
    /// <summary>
    /// Status of the business risk assessment check
    /// </summary>
    [JsonPropertyName("status")]
    public required BusinessVerificationStatusRiskCheck Status { get; init; }

    /// <summary>
    /// A score from 0 to 100 indicating the risk assessment for the business
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Nullable industry prediction details.
    /// </summary>
    [JsonPropertyName("industry_prediction")]
    public required BusinessIndustryPredictionNullable? IndustryPrediction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
