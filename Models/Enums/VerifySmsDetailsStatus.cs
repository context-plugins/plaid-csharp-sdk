using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome status for the associated Identity Verification attempt's <c>verify_sms</c> step. This field will always have the same value as <c>steps.verify_sms</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerifySmsDetailsStatus>))]
public sealed record VerifySmsDetailsStatus : StringEnum<VerifySmsDetailsStatus>
{
    private VerifySmsDetailsStatus(string value) : base(value)
    {
    }

    public static readonly VerifySmsDetailsStatus Success = new("success");

    public static readonly VerifySmsDetailsStatus Failed = new("failed");

    public static VerifySmsDetailsStatus FromValue(string value) => FromValueCore(value);
}
