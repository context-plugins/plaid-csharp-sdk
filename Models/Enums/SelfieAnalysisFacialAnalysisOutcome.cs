using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Outcome of the facial analysis for a specific facial feature.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisFacialAnalysisOutcome>))]
public sealed record SelfieAnalysisFacialAnalysisOutcome : StringEnum<SelfieAnalysisFacialAnalysisOutcome>
{
    private SelfieAnalysisFacialAnalysisOutcome(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisFacialAnalysisOutcome Success = new("success");

    public static readonly SelfieAnalysisFacialAnalysisOutcome Failed = new("failed");

    public static SelfieAnalysisFacialAnalysisOutcome FromValue(string value) => FromValueCore(value);
}
