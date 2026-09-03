using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The verification status to set the account to.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus1>))]
public sealed record VerificationStatus1 : StringEnum<VerificationStatus1>
{
    private VerificationStatus1(string value) : base(value)
    {
    }

    public static readonly VerificationStatus1 AutomaticallyVerified = new("automatically_verified");

    public static readonly VerificationStatus1 VerificationExpired = new("verification_expired");

    public static VerificationStatus1 FromValue(string value) => FromValueCore(value);
}
