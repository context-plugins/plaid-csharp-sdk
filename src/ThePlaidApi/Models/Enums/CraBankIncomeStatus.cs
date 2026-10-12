using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the income sources.
/// <c>ACTIVE</c>: The income source is active.
/// <c>INACTIVE</c>: The income source is inactive.
/// <c>UNKNOWN</c>: The income source status is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraBankIncomeStatus>))]
public sealed record CraBankIncomeStatus : OpenStringEnum<CraBankIncomeStatus>
{
    private CraBankIncomeStatus(string value) : base(value)
    {
    }

    public static readonly CraBankIncomeStatus Active = new("ACTIVE");

    public static readonly CraBankIncomeStatus Inactive = new("INACTIVE");

    public static readonly CraBankIncomeStatus Unknown = new("UNKNOWN");

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
