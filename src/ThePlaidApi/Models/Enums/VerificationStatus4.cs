using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current verification status of an Auth Item initiated through Automated or Manual micro-deposits.  Returned for Auth Items only.
/// <para>
/// <c>pending_automatic_verification</c>: The Item is pending automatic verification.
/// </para>
/// <para>
/// <c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the micro-deposit.
/// </para>
/// <para>
/// <c>automatically_verified</c>: The Item has successfully been automatically verified.
/// </para>
/// <para>
/// <c>manually_verified</c>: The Item has successfully been manually verified.
/// </para>
/// <para>
/// <c>verification_expired</c>: Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.
/// </para>
/// <para>
/// <c>verification_failed</c>: The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.
/// </para>
/// <para>
/// <c>database_matched</c>: (deprecated) The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus4>))]
public sealed record VerificationStatus4 : OpenStringEnum<VerificationStatus4>
{
    private VerificationStatus4(string value) : base(value)
    {
    }

    public static readonly VerificationStatus4 AutomaticallyVerified = new("automatically_verified");

    public static readonly VerificationStatus4 PendingAutomaticVerification = new("pending_automatic_verification");

    public static readonly VerificationStatus4 PendingManualVerification = new("pending_manual_verification");

    public static readonly VerificationStatus4 ManuallyVerified = new("manually_verified");

    public static readonly VerificationStatus4 VerificationExpired = new("verification_expired");

    public static readonly VerificationStatus4 VerificationFailed = new("verification_failed");

    public static readonly VerificationStatus4 DatabaseMatched = new("database_matched");

    public TResult Match<TResult>(Func<TResult> onAutomaticallyVerified,
        Func<TResult> onPendingAutomaticVerification,
        Func<TResult> onPendingManualVerification,
        Func<TResult> onManuallyVerified,
        Func<TResult> onVerificationExpired,
        Func<TResult> onVerificationFailed,
        Func<TResult> onDatabaseMatched,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AutomaticallyVerified => onAutomaticallyVerified(),
            _ when this == PendingAutomaticVerification => onPendingAutomaticVerification(),
            _ when this == PendingManualVerification => onPendingManualVerification(),
            _ when this == ManuallyVerified => onManuallyVerified(),
            _ when this == VerificationExpired => onVerificationExpired(),
            _ when this == VerificationFailed => onVerificationFailed(),
            _ when this == DatabaseMatched => onDatabaseMatched(),
            _ => otherwise(Value)
        };

    public void Match(Action onAutomaticallyVerified,
        Action onPendingAutomaticVerification,
        Action onPendingManualVerification,
        Action onManuallyVerified,
        Action onVerificationExpired,
        Action onVerificationFailed,
        Action onDatabaseMatched,
        Action<string> otherwise)
    {
        if (this == AutomaticallyVerified) onAutomaticallyVerified();
        else if (this == PendingAutomaticVerification) onPendingAutomaticVerification();
        else if (this == PendingManualVerification) onPendingManualVerification();
        else if (this == ManuallyVerified) onManuallyVerified();
        else if (this == VerificationExpired) onVerificationExpired();
        else if (this == VerificationFailed) onVerificationFailed();
        else if (this == DatabaseMatched) onDatabaseMatched();
        else otherwise(Value);
    }
}
