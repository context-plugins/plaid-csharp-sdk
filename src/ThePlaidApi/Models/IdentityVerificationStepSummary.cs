using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Each step will be one of the following values:
/// <para>
///
/// <c>active</c> - This step is the user's current step. They are either in the process of completing this step, or they recently closed their Identity Verification attempt while in the middle of this step. Only one step will be marked as <c>active</c> at any given point.
/// </para>
/// <para>
/// <c>success</c> - The Identity Verification attempt has completed this step.
/// </para>
/// <para>
/// <c>failed</c> - The user failed this step. This can either cause the user to fail the session as a whole, or cause them to fall back to another step depending on how the Identity Verification template is configured. A failed step does not imply a failed session.
/// </para>
/// <para>
/// <c>waiting_for_prerequisite</c> - The user needs to complete another step first, before they progress to this step. This step may never run, depending on if the user fails an earlier step or if the step is only run as a fallback.
/// </para>
/// <para>
/// <c>not_applicable</c> - This step will not be run for this session.
/// </para>
/// <para>
/// <c>skipped</c> - The retry instructions that created this Identity Verification attempt specified that this step should be skipped.
/// </para>
/// <para>
/// <c>expired</c> - This step had not yet been completed when the Identity Verification attempt as a whole expired.
/// </para>
/// <para>
/// <c>canceled</c> - The Identity Verification attempt was canceled before the user completed this step.
/// </para>
/// <para>
/// <c>pending_review</c> - The Identity Verification attempt template was configured to perform a screening that had one or more hits needing review.
/// </para>
/// <para>
/// <c>manually_approved</c> - The step was manually overridden to pass by a team member in the dashboard.
/// </para>
/// <para>
/// <c>manually_rejected</c> - The step was manually overridden to fail by a team member in the dashboard.
/// </para>
/// </summary>
public record IdentityVerificationStepSummary
{
    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("accept_tos")]
    public required IdentityVerificationStepStatus AcceptTos { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("verify_sms")]
    public required IdentityVerificationStepStatus VerifySms { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("kyc_check")]
    public required IdentityVerificationStepStatus KycCheck { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("documentary_verification")]
    public required IdentityVerificationStepStatus DocumentaryVerification { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("selfie_check")]
    public required IdentityVerificationStepStatus SelfieCheck { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("watchlist_screening")]
    public required IdentityVerificationStepStatus WatchlistScreening { get; init; }

    /// <summary>
    /// The status of a step in the Identity Verification process.
    /// </summary>
    [JsonPropertyName("risk_check")]
    public required IdentityVerificationStepStatus RiskCheck { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
