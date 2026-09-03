using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional information for the <c>verify_sms</c> step.
/// </summary>
public record VerifySmsDetails
{
    /// <summary>
    /// The outcome status for the associated Identity Verification attempt's <c>verify_sms</c> step. This field will always have the same value as <c>steps.verify_sms</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required VerifySmsDetailsStatus Status { get; init; }

    /// <summary>
    /// An array where each entry represents a verification attempt for the <c>verify_sms</c> step. Each entry represents one user-submitted phone number. Phone number edits, and in some cases error handling due to edge cases like rate limiting, may generate additional verifications.
    /// </summary>
    [JsonPropertyName("verifications")]
    public required IReadOnlyList<SmsVerification> Verifications { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
