using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An identity verification attempt represents a customer's attempt to verify their identity, reflecting the required steps for completing the session, the results for each step, and information collected in the process.
/// </summary>
public record IdentityVerificationGetResponse
{
    /// <summary>
    /// ID of the associated Identity Verification attempt.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public required DateTimeOffset? CompletedAt { get; init; }

    /// <summary>
    /// The ID for the Identity Verification preceding this session. This field will only be filled if the current Identity Verification is a retry of a previous attempt.
    /// </summary>
    [JsonPropertyName("previous_attempt_id")]
    public required string? PreviousAttemptId { get; init; }

    /// <summary>
    /// A shareable URL that can be sent directly to the user to complete verification
    /// </summary>
    [JsonPropertyName("shareable_url")]
    public required string? ShareableUrl { get; init; }

    /// <summary>
    /// The resource ID and version number of the template configuring the behavior of a given Identity Verification.
    /// </summary>
    [JsonPropertyName("template")]
    public required IdentityVerificationTemplateReference Template { get; init; }

    /// <summary>
    /// The identity data that was either collected from the user or provided via API in order to perform an Identity Verification.
    /// </summary>
    [JsonPropertyName("user")]
    public required IdentityVerificationUserData User { get; init; }

    /// <summary>
    /// The status of this Identity Verification attempt.
    /// <para>
    ///
    /// <c>active</c> - The Identity Verification attempt is incomplete. The user may have completed part of the session, but has neither failed nor passed.
    /// </para>
    /// <para>
    /// <c>success</c> - The Identity Verification attempt has completed, passing all steps defined to the associated Identity Verification template.
    /// </para>
    /// <para>
    /// <c>failed</c> - The user failed one or more steps in the session and was told to contact support.
    /// </para>
    /// <para>
    /// <c>expired</c> - The Identity Verification attempt was active for a long period of time without being completed and was automatically marked as expired. Note that sessions currently do not expire. Automatic expiration is expected to be enabled in the future.
    /// </para>
    /// <para>
    /// <c>canceled</c> - The Identity Verification attempt was canceled, either via the dashboard by a user, or via API. The user may have completed part of the session, but has neither failed nor passed.
    /// </para>
    /// <para>
    /// <c>pending_review</c> - The Identity Verification attempt template was configured to perform a screening that had one or more hits needing review.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required IdentityVerificationStatus Status { get; init; }

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
    [JsonPropertyName("steps")]
    public required IdentityVerificationStepSummary Steps { get; init; }

    /// <summary>
    /// Data, images, analysis, and results from the <c>documentary_verification</c> step. This field will be <c>null</c> unless <c>steps.documentary_verification</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.
    /// </summary>
    [JsonPropertyName("documentary_verification")]
    public required DocumentaryVerification? DocumentaryVerification { get; init; }

    /// <summary>
    /// Additional information for the <c>selfie_check</c> step. This field will be <c>null</c> unless <c>steps.selfie_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.
    /// </summary>
    [JsonPropertyName("selfie_check")]
    public required SelfieCheck? SelfieCheck { get; init; }

    /// <summary>
    /// Additional information for the <c>kyc_check</c> (Data Source Verification) step. This field will be <c>null</c> unless <c>steps.kyc_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.
    /// </summary>
    [JsonPropertyName("kyc_check")]
    public required KycCheckDetails? KycCheck { get; init; }

    /// <summary>
    /// Additional information for the <c>risk_check</c> step.
    /// </summary>
    [JsonPropertyName("risk_check")]
    public required RiskCheckDetails? RiskCheck { get; init; }

    /// <summary>
    /// Additional information for the <c>verify_sms</c> step.
    /// </summary>
    [JsonPropertyName("verify_sms")]
    public required VerifySmsDetails? VerifySms { get; init; }

    /// <summary>
    /// ID of the associated screening.
    /// </summary>
    [JsonPropertyName("watchlist_screening_id")]
    public required string? WatchlistScreeningId { get; init; }

    /// <summary>
    /// Beacon is deprecated in favor of Plaid Protect. This field is only populated for users of the deprecated Beacon product.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string? BeaconUserId { get; init; }

    /// <summary>
    /// Unique user identifier, created by calling <c>/user/create</c>. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. The <c>user_id</c> may only be used instead of the <c>client_user_id</c> if you were not a pre-existing user of <c>/user/create</c> as of December 10, 2025, or if you have since <see href="https://plaid.com/docs/api/users/migrate-to-new-user-apis">migrated to the new User APIs</see>; for more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>. If both this field and a <c>client_user_id</c> are present in a request, the <c>user_id</c> must have been created from the provided <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string? UserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("redacted_at")]
    public required DateTimeOffset? RedactedAt { get; init; }

    /// <summary>
    /// Information about a Protect event including Trust Index score and fraud attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest_scored_protect_event")]
    public IdvProtectEvent? LatestScoredProtectEvent { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
