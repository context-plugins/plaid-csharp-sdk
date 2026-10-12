using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current employment status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmploymentVerificationStatus>))]
public sealed record EmploymentVerificationStatus : OpenStringEnum<EmploymentVerificationStatus>
{
    private EmploymentVerificationStatus(string value) : base(value)
    {
    }

    public static readonly EmploymentVerificationStatus EmploymentStatusActive = new("EMPLOYMENT_STATUS_ACTIVE");

    public static readonly EmploymentVerificationStatus EmploymentStatusInactive = new("EMPLOYMENT_STATUS_INACTIVE");

    public TResult Match<TResult>(Func<TResult> onEmploymentStatusActive,
        Func<TResult> onEmploymentStatusInactive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EmploymentStatusActive => onEmploymentStatusActive(),
            _ when this == EmploymentStatusInactive => onEmploymentStatusInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onEmploymentStatusActive, Action onEmploymentStatusInactive, Action<string> otherwise)
    {
        if (this == EmploymentStatusActive) onEmploymentStatusActive();
        else if (this == EmploymentStatusInactive) onEmploymentStatusInactive();
        else otherwise(Value);
    }
}
