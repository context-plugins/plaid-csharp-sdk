using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome status for the individual SMS verification.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SmsVerificationStatus>))]
public sealed record SmsVerificationStatus : StringEnum<SmsVerificationStatus>
{
    private SmsVerificationStatus(string value) : base(value)
    {
    }

    public static readonly SmsVerificationStatus Pending = new("pending");

    public static readonly SmsVerificationStatus Success = new("success");

    public static readonly SmsVerificationStatus Failed = new("failed");

    public static readonly SmsVerificationStatus Canceled = new("canceled");

    public static SmsVerificationStatus FromValue(string value) => FromValueCore(value);
}
