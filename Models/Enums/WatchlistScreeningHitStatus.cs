using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current state of review. All watchlist screening hits begin in a <c>pending_review</c> state but can be changed by creating a review. When a hit is in the <c>pending_review</c> state, it will always show the latest version of the watchlist data Plaid has available and be compared against the latest customer information saved in the watchlist screening. Once a hit has been marked as <c>confirmed</c> or <c>dismissed</c> it will no longer be updated so that the state is as it was when the review was first conducted.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningHitStatus>))]
public sealed record WatchlistScreeningHitStatus : StringEnum<WatchlistScreeningHitStatus>
{
    private WatchlistScreeningHitStatus(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningHitStatus Confirmed = new("confirmed");

    public static readonly WatchlistScreeningHitStatus PendingReview = new("pending_review");

    public static readonly WatchlistScreeningHitStatus Dismissed = new("dismissed");

    public static WatchlistScreeningHitStatus FromValue(string value) => FromValueCore(value);
}
