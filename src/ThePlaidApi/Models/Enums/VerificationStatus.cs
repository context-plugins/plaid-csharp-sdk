using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The verification status. One of the following:
/// <para>
/// <c>"VERIFIED"</c>: The information was successfully verified.
/// </para>
/// <para>
/// <c>"UNVERIFIED"</c>: The verification has not yet been performed.
/// </para>
/// <para>
/// <c>"NEEDS_INFO"</c>: The verification was attempted but could not be completed due to missing information.
/// </para>
/// <para>
/// "<c>UNABLE_TO_VERIFY</c>": The verification was performed and the information could not be verified.
/// </para>
/// <para>
/// <c>"UNKNOWN"</c>: The verification status is unknown.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus>))]
public sealed record VerificationStatus : OpenStringEnum<VerificationStatus>
{
    private VerificationStatus(string value) : base(value)
    {
    }

    public static readonly VerificationStatus Verified = new("VERIFIED");

    public static readonly VerificationStatus Unverified = new("UNVERIFIED");

    public static readonly VerificationStatus NeedsInfo = new("NEEDS_INFO");

    public static readonly VerificationStatus UnableToVerify = new("UNABLE_TO_VERIFY");

    public static readonly VerificationStatus Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onVerified,
        Func<TResult> onUnverified,
        Func<TResult> onNeedsInfo,
        Func<TResult> onUnableToVerify,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Verified => onVerified(),
            _ when this == Unverified => onUnverified(),
            _ when this == NeedsInfo => onNeedsInfo(),
            _ when this == UnableToVerify => onUnableToVerify(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerified,
        Action onUnverified,
        Action onNeedsInfo,
        Action onUnableToVerify,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Verified) onVerified();
        else if (this == Unverified) onUnverified();
        else if (this == NeedsInfo) onNeedsInfo();
        else if (this == UnableToVerify) onUnableToVerify();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
