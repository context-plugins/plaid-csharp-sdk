using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A status enum indicating whether autofill succeeded or failed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityVerificationAutofillStatus>))]
public sealed record IdentityVerificationAutofillStatus : OpenStringEnum<IdentityVerificationAutofillStatus>
{
    private IdentityVerificationAutofillStatus(string value) : base(value)
    {
    }

    public static readonly IdentityVerificationAutofillStatus Success = new("success");

    public static readonly IdentityVerificationAutofillStatus Failed = new("failed");

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
