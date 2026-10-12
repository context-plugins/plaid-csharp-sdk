using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<IdentityVerificationStatus>))]
public sealed record IdentityVerificationStatus : OpenStringEnum<IdentityVerificationStatus>
{
    private IdentityVerificationStatus(string value) : base(value)
    {
    }

    public static readonly IdentityVerificationStatus Active = new("active");

    public static readonly IdentityVerificationStatus Success = new("success");

    public static readonly IdentityVerificationStatus Failed = new("failed");

    public static readonly IdentityVerificationStatus Expired = new("expired");

    public static readonly IdentityVerificationStatus Canceled = new("canceled");

    public static readonly IdentityVerificationStatus PendingReview = new("pending_review");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<TResult> onExpired,
        Func<TResult> onCanceled,
        Func<TResult> onPendingReview,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ when this == Expired => onExpired(),
            _ when this == Canceled => onCanceled(),
            _ when this == PendingReview => onPendingReview(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onSuccess,
        Action onFailed,
        Action onExpired,
        Action onCanceled,
        Action onPendingReview,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else if (this == Expired) onExpired();
        else if (this == Canceled) onCanceled();
        else if (this == PendingReview) onPendingReview();
        else otherwise(Value);
    }
}
