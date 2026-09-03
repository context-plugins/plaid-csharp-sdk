using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The calculated UltraFICO® score.
/// </summary>
public record CraPartnerInsightsUltraFicoScore
{
    /// <summary>
    /// The version of the UltraFICO® score.
    /// </summary>
    [JsonPropertyName("ultrafico_score_version")]
    public string UltraficoScoreVersion { get; } = "1.0";

    /// <summary>
    /// Numeric value of the UltraFICO® score.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// Negative reason codes associated with the score (reasons the score moved downward), in priority order. May contain up to 4 items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negative_reason_codes")]
    [MaxLength(4)]
    public IReadOnlyList<string>? NegativeReasonCodes { get; init; }

    /// <summary>
    /// Positive reason codes associated with the score (reasons the score moved upward), in priority order. May contain up to 4 items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positive_reason_codes")]
    [MaxLength(4)]
    public IReadOnlyList<string>? PositiveReasonCodes { get; init; }

    /// <summary>
    /// Deprecated. Use <c>negative_reason_codes</c> instead. The first reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_1")]
    public string? ReasonCode1 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>negative_reason_codes</c> instead. The second reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_2")]
    public string? ReasonCode2 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>negative_reason_codes</c> instead. The third reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_3")]
    public string? ReasonCode3 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>negative_reason_codes</c> instead. The fourth reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code_4")]
    public string? ReasonCode4 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>positive_reason_codes</c> instead. The first positive reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positive_reason_code_1")]
    public string? PositiveReasonCode1 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>positive_reason_codes</c> instead. The second positive reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positive_reason_code_2")]
    public string? PositiveReasonCode2 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>positive_reason_codes</c> instead. The third positive reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positive_reason_code_3")]
    public string? PositiveReasonCode3 { get; init; }

    /// <summary>
    /// Deprecated. Use <c>positive_reason_codes</c> instead. The fourth positive reason code associated with the score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positive_reason_code_4")]
    public string? PositiveReasonCode4 { get; init; }

    /// <summary>
    /// Whether inquiries adversely affected the score but were not represented in one of the four reason codes. Sometimes referred to as the FACTA Flag.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("did_inquiries_adversely_affect_score")]
    public bool? DidInquiriesAdverselyAffectScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
