using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Assessment of whether the selfie capture is of a real human being, as opposed to a picture of a human on a screen, a picture of a paper cut out, someone wearing a mask, or a deepfake.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisLivenessCheck>))]
public sealed record SelfieAnalysisLivenessCheck : OpenStringEnum<SelfieAnalysisLivenessCheck>
{
    private SelfieAnalysisLivenessCheck(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisLivenessCheck Success = new("success");

    public static readonly SelfieAnalysisLivenessCheck Failed = new("failed");

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
