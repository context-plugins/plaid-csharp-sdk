using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates an Item's micro-deposit-based verification or database verification status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryVerificationStatus>))]
public sealed record LinkDeliveryVerificationStatus : StringEnum<LinkDeliveryVerificationStatus>
{
    private LinkDeliveryVerificationStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryVerificationStatus AutomaticallyVerified = new("automatically_verified");

    public static readonly LinkDeliveryVerificationStatus PendingAutomaticVerification = new("pending_automatic_verification");

    public static readonly LinkDeliveryVerificationStatus PendingManualVerification = new("pending_manual_verification");

    public static readonly LinkDeliveryVerificationStatus ManuallyVerified = new("manually_verified");

    public static readonly LinkDeliveryVerificationStatus VerificationExpired = new("verification_expired");

    public static readonly LinkDeliveryVerificationStatus VerificationFailed = new("verification_failed");

    public static readonly LinkDeliveryVerificationStatus Unsent = new("unsent");

    public static readonly LinkDeliveryVerificationStatus DatabaseMatched = new("database_matched");

    public static readonly LinkDeliveryVerificationStatus DatabaseInsightsPending = new("database_insights_pending");

    public static LinkDeliveryVerificationStatus FromValue(string value) => FromValueCore(value);
}
