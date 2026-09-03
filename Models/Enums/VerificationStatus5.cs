using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates an Item's micro-deposit-based verification or database verification status. This field is only populated when using Auth and falling back to micro-deposit or database verification. Possible values are:
/// <para>
/// <c>pending_automatic_verification</c>: The Item is pending automatic verification.
/// </para>
/// <para>
/// <c>pending_manual_verification</c>: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the code.
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
/// <c>unsent</c>: The Item is pending micro-deposit verification, but Plaid has not yet sent the micro-deposit.
/// </para>
/// <para>
/// <c>database_insights_fail</c>: The Item's numbers have been verified using Plaid's data sources and have signal for being invalid and/or have no signal for being valid. Typically this indicates that the routing number is invalid, the account number does not match the account number format associated with the routing number, or the account has been reported as closed or frozen. Only returned for Auth Items created via Database Auth.
/// </para>
/// <para>
/// <c>database_insights_pass</c>: The Item's numbers have been verified using Plaid's data sources: the routing and account number match a routing and account number of an account recognized on the Plaid network, and the account is not known by Plaid to be frozen or closed. Only returned for Auth Items created via Database Auth.
/// </para>
/// <para>
/// <c>database_insights_pass_with_caution</c>: The Item's numbers have been verified using Plaid's data sources and have some signal for being valid: the routing and account number were not recognized on the Plaid network, but the routing number is valid and the account number is a potential valid account number for that routing number. Only returned for Auth Items created via Database Auth.
/// </para>
/// <para>
/// <c>database_matched</c>: (deprecated) The Item has successfully been verified using Plaid's data sources. Only returned for Auth Items created via Database Match.
/// </para>
/// <para>
/// <c>null</c> or empty string: Neither micro-deposit-based verification nor database verification are being used for the Item.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus5>))]
public sealed record VerificationStatus5 : StringEnum<VerificationStatus5>
{
    private VerificationStatus5(string value) : base(value)
    {
    }

    public static readonly VerificationStatus5 AutomaticallyVerified = new("automatically_verified");

    public static readonly VerificationStatus5 PendingAutomaticVerification = new("pending_automatic_verification");

    public static readonly VerificationStatus5 PendingManualVerification = new("pending_manual_verification");

    public static readonly VerificationStatus5 Unsent = new("unsent");

    public static readonly VerificationStatus5 ManuallyVerified = new("manually_verified");

    public static readonly VerificationStatus5 VerificationExpired = new("verification_expired");

    public static readonly VerificationStatus5 VerificationFailed = new("verification_failed");

    public static readonly VerificationStatus5 DatabaseMatched = new("database_matched");

    public static readonly VerificationStatus5 DatabaseInsightsPass = new("database_insights_pass");

    public static readonly VerificationStatus5 DatabaseInsightsPassWithCaution = new("database_insights_pass_with_caution");

    public static readonly VerificationStatus5 DatabaseInsightsFail = new("database_insights_fail");

    public static VerificationStatus5 FromValue(string value) => FromValueCore(value);
}
