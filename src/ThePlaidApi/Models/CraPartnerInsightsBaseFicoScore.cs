using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the base FICO score associated with an UltraFICO® scoring request.
/// </summary>
public record CraPartnerInsightsBaseFicoScore
{
    /// <summary>
    /// The credit bureau that provided the base FICO score.
    /// </summary>
    [JsonPropertyName("bureau")]
    public required CraPartnerInsightsBureau Bureau { get; init; }

    /// <summary>
    /// Numeric value of the base FICO score.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Reason codes associated with the score, in priority order. May contain up to 4 items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_codes")]
    [MaxLength(4)]
    public IReadOnlyList<string>? ReasonCodes { get; init; }

    /// <summary>
    /// Deprecated. Use <c>reason_codes</c> instead. The first reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_1")]
    public string? ReasonCode1 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>reason_codes</c> instead. The second reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_2")]
    public string? ReasonCode2 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>reason_codes</c> instead. The third reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_3")]
    public string? ReasonCode3 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>reason_codes</c> instead. The fourth reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_4")]
    public string? ReasonCode4 { get; init; }

    /// <summary>
    /// Whether inquiries adversely affected the score but were not represented in one of the four reason codes. Sometimes referred to as the FACTA Flag.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("did_inquiries_adversely_affect_score")]
    public bool? DidInquiriesAdverselyAffectScore { get; init; }

    /// <summary>
    /// The version of the base FICO score model.
    /// </summary>
    [JsonPropertyName("base_fico_score_version")]
    public required CraPartnerInsightsBaseFicoScoreVersion BaseFicoScoreVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
