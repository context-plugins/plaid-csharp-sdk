using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome status for the associated Identity Verification attempt's <c>verify_sms</c> step. This field will always have the same value as <c>steps.verify_sms</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerifySmsDetailsStatus>))]
public sealed record VerifySmsDetailsStatus : OpenStringEnum<VerifySmsDetailsStatus>
{
    private VerifySmsDetailsStatus(string value) : base(value)
    {
    }

    public static readonly VerifySmsDetailsStatus Success = new("success");

    public static readonly VerifySmsDetailsStatus Failed = new("failed");

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
