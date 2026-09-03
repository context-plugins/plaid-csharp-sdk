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
public sealed record VerificationStatus : StringEnum<VerificationStatus>
{
    private VerificationStatus(string value) : base(value)
    {
    }

    public static readonly VerificationStatus Verified = new("VERIFIED");

    public static readonly VerificationStatus Unverified = new("UNVERIFIED");

    public static readonly VerificationStatus NeedsInfo = new("NEEDS_INFO");

    public static readonly VerificationStatus UnableToVerify = new("UNABLE_TO_VERIFY");

    public static readonly VerificationStatus Unknown = new("UNKNOWN");

    public static VerificationStatus FromValue(string value) => FromValueCore(value);
}
