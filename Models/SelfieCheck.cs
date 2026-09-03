using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional information for the <c>selfie_check</c> step. This field will be <c>null</c> unless <c>steps.selfie_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.
/// </summary>
public record SelfieCheck
{
    /// <summary>
    /// The outcome status for the associated Identity Verification attempt's <c>selfie_check</c> step. This field will always have the same value as <c>steps.selfie_check</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required SelfieCheckStatus Status { get; init; }

    /// <summary>
    /// An array of selfies submitted to the <c>selfie_check</c> step. Each entry represents one user submission.
    /// </summary>
    [JsonPropertyName("selfies")]
    public required IReadOnlyList<SelfieCheckSelfie> Selfies { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
