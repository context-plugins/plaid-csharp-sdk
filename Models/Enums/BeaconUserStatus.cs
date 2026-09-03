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
public sealed record BeaconUserStatus : StringEnum<BeaconUserStatus>
{
    private BeaconUserStatus(string value) : base(value)
    {
    }

    public static readonly BeaconUserStatus Rejected = new("rejected");

    public static readonly BeaconUserStatus PendingReview = new("pending_review");

    public static readonly BeaconUserStatus Cleared = new("cleared");

    public static BeaconUserStatus FromValue(string value) => FromValueCore(value);
}
