using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the image quality of the document.
/// </summary>
public record ImageQualityDetails
{
    /// <summary>
    /// The outcome of the glare check.
    /// <para>
    /// <c>success</c> - The image is free of glare.
    /// </para>
    /// <para>
    /// <c>failed</c> - The image contains glare that may obscure document details.
    /// </para>
    /// </summary>
    [JsonPropertyName("glare_check")]
    public required ImageQualityOutcome GlareCheck { get; init; }

    /// <summary>
    /// The outcome of the dimensions check.
    /// <para>
    /// <c>success</c> - The image meets the minimum size and resolution requirements.
    /// </para>
    /// <para>
    /// <c>failed</c> - The image does not meet the minimum size or resolution requirements.
    /// </para>
    /// </summary>
    [JsonPropertyName("dimensions_check")]
    public required ImageQualityOutcome DimensionsCheck { get; init; }

    /// <summary>
    /// The outcome of the blur check.
    /// <para>
    /// <c>success</c> - The image is sufficiently sharp.
    /// </para>
    /// <para>
    /// <c>failed</c> - The image is too blurry for analysis.
    /// </para>
    /// </summary>
    [JsonPropertyName("blur_check")]
    public required ImageQualityOutcome BlurCheck { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
