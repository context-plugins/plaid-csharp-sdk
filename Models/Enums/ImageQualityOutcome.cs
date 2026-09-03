using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the image quality check.
/// <para>
///
/// <c>success</c> - The check passed.
/// </para>
/// <para>
/// <c>failed</c> - The check did not pass.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ImageQualityOutcome>))]
public sealed record ImageQualityOutcome : StringEnum<ImageQualityOutcome>
{
    private ImageQualityOutcome(string value) : base(value)
    {
    }

    public static readonly ImageQualityOutcome Success = new("success");

    public static readonly ImageQualityOutcome Failed = new("failed");

    public static ImageQualityOutcome FromValue(string value) => FromValueCore(value);
}
