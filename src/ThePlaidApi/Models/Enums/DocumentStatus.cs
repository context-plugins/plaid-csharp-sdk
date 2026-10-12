using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An outcome status for this specific document submission. Distinct from the overall <c>documentary_verification.status</c> that summarizes the verification outcome from one or more documents.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentStatus>))]
public sealed record DocumentStatus : OpenStringEnum<DocumentStatus>
{
    private DocumentStatus(string value) : base(value)
    {
    }

    public static readonly DocumentStatus Success = new("success");

    public static readonly DocumentStatus Failed = new("failed");

    public static readonly DocumentStatus ManuallyApproved = new("manually_approved");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<TResult> onManuallyApproved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ when this == ManuallyApproved => onManuallyApproved(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailed, Action onManuallyApproved, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else if (this == ManuallyApproved) onManuallyApproved();
        else otherwise(Value);
    }
}
