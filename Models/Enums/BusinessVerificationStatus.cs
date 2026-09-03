using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the KYB (Know Your Business) identity assessment check
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatus>))]
public sealed record BusinessVerificationStatus : StringEnum<BusinessVerificationStatus>
{
    private BusinessVerificationStatus(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatus Active = new("active");

    public static readonly BusinessVerificationStatus Success = new("success");

    public static readonly BusinessVerificationStatus Failed = new("failed");

    public static BusinessVerificationStatus FromValue(string value) => FromValueCore(value);
}
