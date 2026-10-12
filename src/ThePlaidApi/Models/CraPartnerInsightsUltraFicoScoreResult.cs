using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The result of a single UltraFICO® score generation request.
/// </summary>
public record CraPartnerInsightsUltraFicoScoreResult
{
    /// <summary>
    /// Client-generated identifier that can be used to correlate scoring requests with their scoring results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_correlation_id")]
    public string? RequestCorrelationId { get; init; }

    /// <summary>
    /// FICO-provided identifier that uniquely identifies this score generation request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fico_scoring_request_id")]
    public string? FicoScoringRequestId { get; init; }

    /// <summary>
    /// The calculated UltraFICO® score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultrafico_score")]
    public CraPartnerInsightsUltraFicoScore? UltraficoScore { get; init; }

    /// <summary>
    /// Human-readable description of why the UltraFICO® score could not be computed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_reason")]
    public string? ErrorReason { get; init; }

    /// <summary>
    /// FICO exclusion code indicating why an UltraFICO® score could not be computed due to consumer-data conditions (e.g. insufficient account history). <c>null</c> when the exclusion code is not set; "0" when a score was produced.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exclusion_code")]
    public string? ExclusionCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
