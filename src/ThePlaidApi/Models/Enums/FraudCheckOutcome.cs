using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the fraud check.
/// <para>
///
/// <c>success</c> - The check passed.
/// </para>
/// <para>
/// <c>failed</c> - The check did not pass.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudCheckOutcome>))]
public sealed record FraudCheckOutcome : OpenStringEnum<FraudCheckOutcome>
{
    private FraudCheckOutcome(string value) : base(value)
    {
    }

    public static readonly FraudCheckOutcome Success = new("success");

    public static readonly FraudCheckOutcome Failed = new("failed");

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
