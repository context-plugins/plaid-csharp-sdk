using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Instructions for the <c>custom</c> retry strategy specifying which steps should be required or skipped.
/// <para>
///
/// Note:
/// </para>
/// <para>
///
/// This field must be provided when the retry strategy is <c>custom</c> and must be omitted otherwise.
/// </para>
/// <para>
/// Custom retries override settings in your Plaid Template. For example, if your Plaid Template has <c>verify_sms</c> disabled, a custom retry with <c>verify_sms</c> enabled will still require the step.
/// </para>
/// <para>
/// The <c>selfie_check</c> step is currently not supported on the sandbox server. Sandbox requests will silently disable the <c>selfie_check</c> step when provided.
/// </para>
/// </summary>
public record IdentityVerificationRetryRequestStepsObject
{
    /// <summary>
    /// A boolean field specifying whether the new session should require or skip the <c>verify_sms</c> step.
    /// </summary>
    [JsonPropertyName("verify_sms")]
    public required bool VerifySms { get; init; }

    /// <summary>
    /// A boolean field specifying whether the new session should require or skip the <c>kyc_check</c> (Data Source Verification) step.
    /// </summary>
    [JsonPropertyName("kyc_check")]
    public required bool KycCheck { get; init; }

    /// <summary>
    /// A boolean field specifying whether the new session should require or skip the <c>documentary_verification</c> step.
    /// </summary>
    [JsonPropertyName("documentary_verification")]
    public required bool DocumentaryVerification { get; init; }

    /// <summary>
    /// A boolean field specifying whether the new session should require or skip the <c>selfie_check</c> step. If a previous session has already passed the <c>selfie_check</c> step, the new selfie check will be a Selfie Reauthentication check, in which the selfie is tested for liveness and for consistency with the previous selfie.
    /// </summary>
    [JsonPropertyName("selfie_check")]
    public required bool SelfieCheck { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
