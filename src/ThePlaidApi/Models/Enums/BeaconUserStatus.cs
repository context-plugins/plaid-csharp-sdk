using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A status of a Beacon User.
/// <para>
/// <c>rejected</c>: The Beacon User has been rejected for fraud. Users can be automatically or manually rejected.
/// </para>
/// <para>
/// <c>pending_review</c>: The Beacon User has been marked for review.
/// </para>
/// <para>
/// <c>cleared</c>: The Beacon User has been cleared of fraud.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconUserStatus>))]
public sealed record BeaconUserStatus : OpenStringEnum<BeaconUserStatus>
{
    private BeaconUserStatus(string value) : base(value)
    {
    }

    public static readonly BeaconUserStatus Rejected = new("rejected");

    public static readonly BeaconUserStatus PendingReview = new("pending_review");

    public static readonly BeaconUserStatus Cleared = new("cleared");

    public TResult Match<TResult>(Func<TResult> onRejected,
        Func<TResult> onPendingReview,
        Func<TResult> onCleared,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Rejected => onRejected(),
            _ when this == PendingReview => onPendingReview(),
            _ when this == Cleared => onCleared(),
            _ => otherwise(Value)
        };

    public void Match(Action onRejected, Action onPendingReview, Action onCleared, Action<string> otherwise)
    {
        if (this == Rejected) onRejected();
        else if (this == PendingReview) onPendingReview();
        else if (this == Cleared) onCleared();
        else otherwise(Value);
    }
}
