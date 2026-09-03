using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome status for the associated Identity Verification attempt's <c>selfie_check</c> step. This field will always have the same value as <c>steps.selfie_check</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieCheckStatus>))]
public sealed record SelfieCheckStatus : StringEnum<SelfieCheckStatus>
{
    private SelfieCheckStatus(string value) : base(value)
    {
    }

    public static readonly SelfieCheckStatus Success = new("success");

    public static readonly SelfieCheckStatus Failed = new("failed");

    public static SelfieCheckStatus FromValue(string value) => FromValueCore(value);
}
