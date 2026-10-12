using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates an Item's micro-deposit-based verification or database verification status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryVerificationStatus>))]
public sealed record LinkDeliveryVerificationStatus : OpenStringEnum<LinkDeliveryVerificationStatus>
{
    private LinkDeliveryVerificationStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryVerificationStatus AutomaticallyVerified = new("automatically_verified");

    public static readonly LinkDeliveryVerificationStatus PendingAutomaticVerification = new(
        "pending_automatic_verification");

    public static readonly LinkDeliveryVerificationStatus PendingManualVerification = new(
        "pending_manual_verification");

    public static readonly LinkDeliveryVerificationStatus ManuallyVerified = new("manually_verified");

    public static readonly LinkDeliveryVerificationStatus VerificationExpired = new("verification_expired");

    public static readonly LinkDeliveryVerificationStatus VerificationFailed = new("verification_failed");

    public static readonly LinkDeliveryVerificationStatus Unsent = new("unsent");

    public static readonly LinkDeliveryVerificationStatus DatabaseMatched = new("database_matched");

    public static readonly LinkDeliveryVerificationStatus DatabaseInsightsPending = new("database_insights_pending");

    public TResult Match<TResult>(Func<TResult> onAutomaticallyVerified,
        Func<TResult> onPendingAutomaticVerification,
        Func<TResult> onPendingManualVerification,
        Func<TResult> onManuallyVerified,
        Func<TResult> onVerificationExpired,
        Func<TResult> onVerificationFailed,
        Func<TResult> onUnsent,
        Func<TResult> onDatabaseMatched,
        Func<TResult> onDatabaseInsightsPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AutomaticallyVerified => onAutomaticallyVerified(),
            _ when this == PendingAutomaticVerification => onPendingAutomaticVerification(),
            _ when this == PendingManualVerification => onPendingManualVerification(),
            _ when this == ManuallyVerified => onManuallyVerified(),
            _ when this == VerificationExpired => onVerificationExpired(),
            _ when this == VerificationFailed => onVerificationFailed(),
            _ when this == Unsent => onUnsent(),
            _ when this == DatabaseMatched => onDatabaseMatched(),
            _ when this == DatabaseInsightsPending => onDatabaseInsightsPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onAutomaticallyVerified,
        Action onPendingAutomaticVerification,
        Action onPendingManualVerification,
        Action onManuallyVerified,
        Action onVerificationExpired,
        Action onVerificationFailed,
        Action onUnsent,
        Action onDatabaseMatched,
        Action onDatabaseInsightsPending,
        Action<string> otherwise)
    {
        if (this == AutomaticallyVerified) onAutomaticallyVerified();
        else if (this == PendingAutomaticVerification) onPendingAutomaticVerification();
        else if (this == PendingManualVerification) onPendingManualVerification();
        else if (this == ManuallyVerified) onManuallyVerified();
        else if (this == VerificationExpired) onVerificationExpired();
        else if (this == VerificationFailed) onVerificationFailed();
        else if (this == Unsent) onUnsent();
        else if (this == DatabaseMatched) onDatabaseMatched();
        else if (this == DatabaseInsightsPending) onDatabaseInsightsPending();
        else otherwise(Value);
    }
}
