using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the overall business verification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatusOverall>))]
public sealed record BusinessVerificationStatusOverall : StringEnum<BusinessVerificationStatusOverall>
{
    private BusinessVerificationStatusOverall(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatusOverall Active = new("active");

    public static readonly BusinessVerificationStatusOverall Success = new("success");

    public static readonly BusinessVerificationStatusOverall Failed = new("failed");

    public static BusinessVerificationStatusOverall FromValue(string value) => FromValueCore(value);
}
