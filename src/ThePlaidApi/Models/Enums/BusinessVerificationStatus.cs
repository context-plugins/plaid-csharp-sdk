using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the KYB (Know Your Business) identity assessment check
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatus>))]
public sealed record BusinessVerificationStatus : OpenStringEnum<BusinessVerificationStatus>
{
    private BusinessVerificationStatus(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatus Active = new("active");

    public static readonly BusinessVerificationStatus Success = new("success");

    public static readonly BusinessVerificationStatus Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onSuccess, Action onFailed, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
