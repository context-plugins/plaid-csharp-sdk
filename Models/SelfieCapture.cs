using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The image or video capture of a selfie. Only one of <c>image_url</c> or <c>video_url</c> will be populated per selfie. In the vast majority of sessions Plaid records a short video of the user, so <c>video_url</c> is populated and <c>image_url</c> is <c>null</c>. <c>image_url</c> is only populated in the rare passive-liveness fallback case, where the user's device could not complete the standard video liveness capture (for example, a camera or streaming error) and submitted a single still image instead.
/// </summary>
public record SelfieCapture
{
    /// <summary>
    /// Temporary URL for downloading a still-image selfie capture. This field is only populated when the session fell back to passive (image-based) liveness. For the majority of selfie checks this field is <c>null</c> and <c>video_url</c> is populated instead.
    /// </summary>
    [JsonPropertyName("image_url")]
    public required string? ImageUrl { get; init; }

    /// <summary>
    /// Temporary URL for downloading a video selfie capture. This is the standard selfie capture for Identity Verification. Plaid records a short video of the user during the Selfie Check liveness step, so this field is populated for the vast majority of selfie checks.
    /// </summary>
    [JsonPropertyName("video_url")]
    public required string? VideoUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
