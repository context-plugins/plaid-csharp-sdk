using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Assessment of whether the selfie capture is of a real human being, as opposed to a picture of a human on a screen, a picture of a paper cut out, someone wearing a mask, or a deepfake.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisLivenessCheck>))]
public sealed record SelfieAnalysisLivenessCheck : StringEnum<SelfieAnalysisLivenessCheck>
{
    private SelfieAnalysisLivenessCheck(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisLivenessCheck Success = new("success");

    public static readonly SelfieAnalysisLivenessCheck Failed = new("failed");

    public static SelfieAnalysisLivenessCheck FromValue(string value) => FromValueCore(value);
}
