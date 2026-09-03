using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The verification refresh status. One of the following:
/// <para>
/// <c>"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED"</c> User presence is required to refresh an income verification.
/// <c>"VERIFICATION_REFRESH_SUCCESSFUL"</c> The income verification refresh was successful.
/// <c>"VERIFICATION_REFRESH_NOT_FOUND"</c> No new data was found after the income verification refresh.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationRefreshStatus>))]
public sealed record VerificationRefreshStatus : StringEnum<VerificationRefreshStatus>
{
    private VerificationRefreshStatus(string value) : base(value)
    {
    }

    public static readonly VerificationRefreshStatus VerificationRefreshStatusUserPresenceRequired = new("VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED");

    public static readonly VerificationRefreshStatus VerificationRefreshSuccessful = new("VERIFICATION_REFRESH_SUCCESSFUL");

    public static readonly VerificationRefreshStatus VerificationRefreshNotFound = new("VERIFICATION_REFRESH_NOT_FOUND");

    public static VerificationRefreshStatus FromValue(string value) => FromValueCore(value);
}
