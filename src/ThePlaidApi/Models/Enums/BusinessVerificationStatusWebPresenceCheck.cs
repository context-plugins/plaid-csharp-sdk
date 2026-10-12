using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the digital presence check
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatusWebPresenceCheck>))]
public sealed record BusinessVerificationStatusWebPresenceCheck : OpenStringEnum<BusinessVerificationStatusWebPresenceCheck>
{
    private BusinessVerificationStatusWebPresenceCheck(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatusWebPresenceCheck Active = new("active");

    public static readonly BusinessVerificationStatusWebPresenceCheck Success = new("success");

    public static readonly BusinessVerificationStatusWebPresenceCheck Failed = new("failed");

    public static readonly BusinessVerificationStatusWebPresenceCheck NotApplicable = new("not_applicable");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<TResult> onNotApplicable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ when this == NotApplicable => onNotApplicable(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onSuccess,
        Action onFailed,
        Action onNotApplicable,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else if (this == NotApplicable) onNotApplicable();
        else otherwise(Value);
    }
}
