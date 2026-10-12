using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the income source.
/// <c>ACTIVE</c>: The income source is active.
/// <c>INACTIVE</c>: The income source is inactive.
/// <c>UNKNOWN</c>: The income source status is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraVerificationIncomeStatus>))]
public sealed record CraVerificationIncomeStatus : OpenStringEnum<CraVerificationIncomeStatus>
{
    private CraVerificationIncomeStatus(string value) : base(value)
    {
    }

    public static readonly CraVerificationIncomeStatus Active = new("ACTIVE");

    public static readonly CraVerificationIncomeStatus Inactive = new("INACTIVE");

    public static readonly CraVerificationIncomeStatus Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onInactive,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action onUnknown, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
