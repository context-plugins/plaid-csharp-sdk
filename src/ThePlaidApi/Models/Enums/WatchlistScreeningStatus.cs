using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningStatus>))]
public sealed record WatchlistScreeningStatus : OpenStringEnum<WatchlistScreeningStatus>
{
    private WatchlistScreeningStatus(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningStatus Rejected = new("rejected");

    public static readonly WatchlistScreeningStatus PendingReview = new("pending_review");

    public static readonly WatchlistScreeningStatus Cleared = new("cleared");

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
