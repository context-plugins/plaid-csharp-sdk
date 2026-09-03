using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Captures and analysis from a user's selfie.
/// </summary>
public record SelfieCheckSelfie
{
    /// <summary>
    /// An outcome status for this specific selfie. Distinct from the overall <c>selfie_check.status</c> that summarizes the verification outcome from one or more selfies.
    /// </summary>
    [JsonPropertyName("status")]
    public required SelfieStatus Status { get; init; }

    /// <summary>
    /// The <c>attempt</c> field begins with 1 and increments with each subsequent selfie upload.
    /// </summary>
    [JsonPropertyName("attempt")]
    public required int Attempt { get; init; }

    /// <summary>
    /// The image or video capture of a selfie. Only one of <c>image_url</c> or <c>video_url</c> will be populated per selfie. In the vast majority of sessions Plaid records a short video of the user, so <c>video_url</c> is populated and <c>image_url</c> is <c>null</c>. <c>image_url</c> is only populated in the rare passive-liveness fallback case, where the user's device could not complete the standard video liveness capture (for example, a camera or streaming error) and submitted a single still image instead.
    /// </summary>
    [JsonPropertyName("capture")]
    public required SelfieCapture Capture { get; init; }

    /// <summary>
    /// High level descriptions of how the associated selfie was processed. If a selfie fails verification, the details in the <c>analysis</c> object should help clarify why the selfie was rejected.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required SelfieAnalysis Analysis { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
