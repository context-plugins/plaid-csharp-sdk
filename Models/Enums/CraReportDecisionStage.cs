using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The stage in the lending lifecycle for which the report is being retrieved.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraReportDecisionStage>))]
public sealed record CraReportDecisionStage : StringEnum<CraReportDecisionStage>
{
    private CraReportDecisionStage(string value) : base(value)
    {
    }

    public static readonly CraReportDecisionStage Prequalification = new("PREQUALIFICATION");

    public static readonly CraReportDecisionStage Decisioning = new("DECISIONING");

    public static readonly CraReportDecisionStage Servicing = new("SERVICING");

    public static CraReportDecisionStage FromValue(string value) => FromValueCore(value);
}
