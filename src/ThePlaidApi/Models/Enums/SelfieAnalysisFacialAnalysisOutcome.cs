using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Outcome of the facial analysis for a specific facial feature.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisFacialAnalysisOutcome>))]
public sealed record SelfieAnalysisFacialAnalysisOutcome : OpenStringEnum<SelfieAnalysisFacialAnalysisOutcome>
{
    private SelfieAnalysisFacialAnalysisOutcome(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisFacialAnalysisOutcome Success = new("success");

    public static readonly SelfieAnalysisFacialAnalysisOutcome Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailed, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
