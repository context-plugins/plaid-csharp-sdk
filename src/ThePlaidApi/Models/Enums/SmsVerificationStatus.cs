using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome status for the individual SMS verification.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SmsVerificationStatus>))]
public sealed record SmsVerificationStatus : OpenStringEnum<SmsVerificationStatus>
{
    private SmsVerificationStatus(string value) : base(value)
    {
    }

    public static readonly SmsVerificationStatus Pending = new("pending");

    public static readonly SmsVerificationStatus Success = new("success");

    public static readonly SmsVerificationStatus Failed = new("failed");

    public static readonly SmsVerificationStatus Canceled = new("canceled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<TResult> onCanceled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ when this == Canceled => onCanceled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onSuccess, Action onFailed, Action onCanceled, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else if (this == Canceled) onCanceled();
        else otherwise(Value);
    }
}
