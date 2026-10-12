using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// High level descriptions of how the associated selfie was processed. If a selfie fails verification, the details in the <c>analysis</c> object should help clarify why the selfie was rejected.
/// </summary>
public record SelfieAnalysis
{
    /// <summary>
    /// Information about the comparison between the selfie and the document (if documentary verification also ran).
    /// </summary>
    [JsonPropertyName("document_comparison")]
    public required SelfieAnalysisDocumentComparison DocumentComparison { get; init; }

    /// <summary>
    /// Assessment of whether the selfie capture is of a real human being, as opposed to a picture of a human on a screen, a picture of a paper cut out, someone wearing a mask, or a deepfake.
    /// </summary>
    [JsonPropertyName("liveness_check")]
    public required SelfieAnalysisLivenessCheck LivenessCheck { get; init; }

    /// <summary>
    /// Age-estimation results from the selfie capture. This field is <c>null</c> when an age range could not be estimated from the selfie capture.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("age_check")]
    public SelfieAgeCheck? AgeCheck { get; init; }

    /// <summary>
    /// Analysis of the facial features of the selfie when compared to the face in the uploaded document, if one is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facial_analysis")]
    public SelfieAnalysisFacialAnalysis? FacialAnalysis { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
