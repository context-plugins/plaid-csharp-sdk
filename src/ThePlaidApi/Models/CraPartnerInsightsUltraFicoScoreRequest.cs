using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration required to generate a single UltraFICO® score.
/// </summary>
public record CraPartnerInsightsUltraFicoScoreRequest
{
    /// <summary>
    /// The version of the UltraFICO® score.
    /// </summary>
    [JsonPropertyName("ultrafico_score_version")]
    public required CraPartnerInsightsUltraFicoScoreVersion UltraficoScoreVersion { get; init; }

    /// <summary>
    /// FICO identifier for a particular scoring request. Should only be provided by FICO as part of the FICO-led flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fico_scoring_request_id")]
    public string? FicoScoringRequestId { get; init; }

    /// <summary>
    /// Client-generated identifier that can be used to correlate scoring requests with their scoring results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_correlation_id")]
    public string? RequestCorrelationId { get; init; }

    /// <summary>
    /// Details about the base FICO score associated with an UltraFICO® scoring request.
    /// </summary>
    [JsonPropertyName("base_fico_score")]
    public required CraPartnerInsightsBaseFicoScore BaseFicoScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
