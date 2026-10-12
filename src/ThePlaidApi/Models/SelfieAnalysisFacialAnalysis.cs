using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Analysis of the facial features of the selfie when compared to the face in the uploaded document, if one is present.
/// </summary>
public record SelfieAnalysisFacialAnalysis
{
    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("left_eye")]
    public required SelfieAnalysisFacialAnalysisOutcome LeftEye { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("right_eye")]
    public required SelfieAnalysisFacialAnalysisOutcome RightEye { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("left_brow")]
    public required SelfieAnalysisFacialAnalysisOutcome LeftBrow { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("right_brow")]
    public required SelfieAnalysisFacialAnalysisOutcome RightBrow { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("forehead")]
    public required SelfieAnalysisFacialAnalysisOutcome Forehead { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("middle_forehead")]
    public required SelfieAnalysisFacialAnalysisOutcome MiddleForehead { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("nose")]
    public required SelfieAnalysisFacialAnalysisOutcome Nose { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("philtrum")]
    public required SelfieAnalysisFacialAnalysisOutcome Philtrum { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("mouth")]
    public required SelfieAnalysisFacialAnalysisOutcome Mouth { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("jaw")]
    public required SelfieAnalysisFacialAnalysisOutcome Jaw { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("left_cheek")]
    public required SelfieAnalysisFacialAnalysisOutcome LeftCheek { get; init; }

    /// <summary>
    /// Outcome of the facial analysis for a specific facial feature.
    /// </summary>
    [JsonPropertyName("right_cheek")]
    public required SelfieAnalysisFacialAnalysisOutcome RightCheek { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
