using System;
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
public sealed record VerificationRefreshStatus : OpenStringEnum<VerificationRefreshStatus>
{
    private VerificationRefreshStatus(string value) : base(value)
    {
    }

    public static readonly VerificationRefreshStatus VerificationRefreshStatusUserPresenceRequired = new(
        "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED");

    public static readonly VerificationRefreshStatus VerificationRefreshSuccessful = new(
        "VERIFICATION_REFRESH_SUCCESSFUL");

    public static readonly VerificationRefreshStatus VerificationRefreshNotFound = new(
        "VERIFICATION_REFRESH_NOT_FOUND");

    public TResult Match<TResult>(Func<TResult> onVerificationRefreshStatusUserPresenceRequired,
        Func<TResult> onVerificationRefreshSuccessful,
        Func<TResult> onVerificationRefreshNotFound,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this ==
                VerificationRefreshStatusUserPresenceRequired => onVerificationRefreshStatusUserPresenceRequired(),
            _ when this == VerificationRefreshSuccessful => onVerificationRefreshSuccessful(),
            _ when this == VerificationRefreshNotFound => onVerificationRefreshNotFound(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerificationRefreshStatusUserPresenceRequired,
        Action onVerificationRefreshSuccessful,
        Action onVerificationRefreshNotFound,
        Action<string> otherwise)
    {
        if (this == VerificationRefreshStatusUserPresenceRequired) onVerificationRefreshStatusUserPresenceRequired();
        else if (this == VerificationRefreshSuccessful) onVerificationRefreshSuccessful();
        else if (this == VerificationRefreshNotFound) onVerificationRefreshNotFound();
        else otherwise(Value);
    }
}
