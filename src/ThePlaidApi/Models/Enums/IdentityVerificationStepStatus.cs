using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of a step in the Identity Verification process.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityVerificationStepStatus>))]
public sealed record IdentityVerificationStepStatus : OpenStringEnum<IdentityVerificationStepStatus>
{
    private IdentityVerificationStepStatus(string value) : base(value)
    {
    }

    public static readonly IdentityVerificationStepStatus Success = new("success");

    public static readonly IdentityVerificationStepStatus Active = new("active");

    public static readonly IdentityVerificationStepStatus Failed = new("failed");

    public static readonly IdentityVerificationStepStatus WaitingForPrerequisite = new("waiting_for_prerequisite");

    public static readonly IdentityVerificationStepStatus NotApplicable = new("not_applicable");

    public static readonly IdentityVerificationStepStatus Skipped = new("skipped");

    public static readonly IdentityVerificationStepStatus Expired = new("expired");

    public static readonly IdentityVerificationStepStatus Canceled = new("canceled");

    public static readonly IdentityVerificationStepStatus PendingReview = new("pending_review");

    public static readonly IdentityVerificationStepStatus ManuallyApproved = new("manually_approved");

    public static readonly IdentityVerificationStepStatus ManuallyRejected = new("manually_rejected");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onActive,
        Func<TResult> onFailed,
        Func<TResult> onWaitingForPrerequisite,
        Func<TResult> onNotApplicable,
        Func<TResult> onSkipped,
        Func<TResult> onExpired,
        Func<TResult> onCanceled,
        Func<TResult> onPendingReview,
        Func<TResult> onManuallyApproved,
        Func<TResult> onManuallyRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Active => onActive(),
            _ when this == Failed => onFailed(),
            _ when this == WaitingForPrerequisite => onWaitingForPrerequisite(),
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == Skipped => onSkipped(),
            _ when this == Expired => onExpired(),
            _ when this == Canceled => onCanceled(),
            _ when this == PendingReview => onPendingReview(),
            _ when this == ManuallyApproved => onManuallyApproved(),
            _ when this == ManuallyRejected => onManuallyRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess,
        Action onActive,
        Action onFailed,
        Action onWaitingForPrerequisite,
        Action onNotApplicable,
        Action onSkipped,
        Action onExpired,
        Action onCanceled,
        Action onPendingReview,
        Action onManuallyApproved,
        Action onManuallyRejected,
        Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Active) onActive();
        else if (this == Failed) onFailed();
        else if (this == WaitingForPrerequisite) onWaitingForPrerequisite();
        else if (this == NotApplicable) onNotApplicable();
        else if (this == Skipped) onSkipped();
        else if (this == Expired) onExpired();
        else if (this == Canceled) onCanceled();
        else if (this == PendingReview) onPendingReview();
        else if (this == ManuallyApproved) onManuallyApproved();
        else if (this == ManuallyRejected) onManuallyRejected();
        else otherwise(Value);
    }
}
