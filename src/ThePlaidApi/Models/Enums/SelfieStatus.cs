using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An outcome status for this specific selfie. Distinct from the overall <c>selfie_check.status</c> that summarizes the verification outcome from one or more selfies.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieStatus>))]
public sealed record SelfieStatus : OpenStringEnum<SelfieStatus>
{
    private SelfieStatus(string value) : base(value)
    {
    }

    public static readonly SelfieStatus Success = new("success");

    public static readonly SelfieStatus Failed = new("failed");

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
