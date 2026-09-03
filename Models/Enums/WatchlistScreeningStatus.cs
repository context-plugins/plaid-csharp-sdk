using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningStatus>))]
public sealed record WatchlistScreeningStatus : StringEnum<WatchlistScreeningStatus>
{
    private WatchlistScreeningStatus(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningStatus Rejected = new("rejected");

    public static readonly WatchlistScreeningStatus PendingReview = new("pending_review");

    public static readonly WatchlistScreeningStatus Cleared = new("cleared");

    public static WatchlistScreeningStatus FromValue(string value) => FromValueCore(value);
}
