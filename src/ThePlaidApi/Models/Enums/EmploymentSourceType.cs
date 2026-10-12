using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of source employment data that users should be able to share
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmploymentSourceType>))]
public sealed record EmploymentSourceType : OpenStringEnum<EmploymentSourceType>
{
    private EmploymentSourceType(string value) : base(value)
    {
    }

    public static readonly EmploymentSourceType Bank = new("bank");

    public static readonly EmploymentSourceType Payroll = new("payroll");

    public TResult Match<TResult>(Func<TResult> onBank, Func<TResult> onPayroll, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bank => onBank(),
            _ when this == Payroll => onPayroll(),
            _ => otherwise(Value)
        };

    public void Match(Action onBank, Action onPayroll, Action<string> otherwise)
    {
        if (this == Bank) onBank();
        else if (this == Payroll) onPayroll();
        else otherwise(Value);
    }
}
