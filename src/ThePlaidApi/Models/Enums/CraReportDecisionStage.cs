using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The stage in the lending lifecycle for which the report is being retrieved.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraReportDecisionStage>))]
public sealed record CraReportDecisionStage : OpenStringEnum<CraReportDecisionStage>
{
    private CraReportDecisionStage(string value) : base(value)
    {
    }

    public static readonly CraReportDecisionStage Prequalification = new("PREQUALIFICATION");

    public static readonly CraReportDecisionStage Decisioning = new("DECISIONING");

    public static readonly CraReportDecisionStage Servicing = new("SERVICING");

    public TResult Match<TResult>(Func<TResult> onPrequalification,
        Func<TResult> onDecisioning,
        Func<TResult> onServicing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Prequalification => onPrequalification(),
            _ when this == Decisioning => onDecisioning(),
            _ when this == Servicing => onServicing(),
            _ => otherwise(Value)
        };

    public void Match(Action onPrequalification, Action onDecisioning, Action onServicing, Action<string> otherwise)
    {
        if (this == Prequalification) onPrequalification();
        else if (this == Decisioning) onDecisioning();
        else if (this == Servicing) onServicing();
        else otherwise(Value);
    }
}
