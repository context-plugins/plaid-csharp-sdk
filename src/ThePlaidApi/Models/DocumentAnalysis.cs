using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// High level descriptions of how the associated document was processed. If a document fails verification, the details in the <c>analysis</c> object should help clarify why the document was rejected.
/// </summary>
public record DocumentAnalysis
{
    /// <summary>
    /// High level summary of whether the document in the provided image matches the formatting rules and security checks for the associated jurisdiction.
    /// <para>
    /// For example, most identity documents have formatting rules like the following:
    /// </para>
    /// <para>
    ///
    /// The image of the person's face must have a certain contrast in order to highlight skin tone
    /// </para>
    /// <para>
    ///
    /// The subject in the document's image must remove eye glasses and pose in a certain way
    /// </para>
    /// <para>
    ///
    /// The informational fields (name, date of birth, ID number, etc.) must be colored and aligned according to specific rules
    /// </para>
    /// <para>
    ///
    /// Security features like watermarks and background patterns must be present
    /// </para>
    /// <para>
    /// So a <c>match</c> status for this field indicates that the document in the provided image seems to conform to the various formatting and security rules associated with the detected document.
    /// </para>
    /// </summary>
    [JsonPropertyName("authenticity")]
    public required DocumentAuthenticityMatchCode Authenticity { get; init; }

    /// <summary>
    /// A high level description of the quality of the image the user submitted.
    /// <para>
    /// For example, an image that is blurry, distorted by glare from a nearby light source, or improperly framed might be marked as low or medium quality. Poor quality images are more likely to fail OCR and/or template conformity checks.
    /// </para>
    /// <para>
    /// Note: By default, Plaid will let a user recapture document images twice before failing the entire session if we attribute the failure to low image quality.
    /// </para>
    /// </summary>
    [JsonPropertyName("image_quality")]
    public required ImageQuality ImageQuality { get; init; }

    /// <summary>
    /// Analysis of the data extracted from the submitted document.
    /// </summary>
    [JsonPropertyName("extracted_data")]
    public required PhysicalDocumentExtractedDataAnalysis? ExtractedData { get; init; }

    /// <summary>
    /// Details about the fraud analysis performed on the document.
    /// </summary>
    [JsonPropertyName("fraud_analysis_details")]
    public required FraudAnalysisDetails? FraudAnalysisDetails { get; init; }

    /// <summary>
    /// Details about the image quality of the document.
    /// </summary>
    [JsonPropertyName("image_quality_details")]
    public required ImageQualityDetails? ImageQualityDetails { get; init; }

    /// <summary>
    /// Details about the human review check, which refers to a check that is performed by a document specialist.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("human_review")]
    public HumanReview? HumanReview { get; init; }

    /// <summary>
    /// Analyzed AAMVA data for the associated hit.
    /// <para>
    /// Note: This field is only available for U.S. driver's licenses issued by participating states.
    /// </para>
    /// </summary>
    [JsonPropertyName("aamva_verification")]
    public required AamvaAnalysis? AamvaVerification { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
