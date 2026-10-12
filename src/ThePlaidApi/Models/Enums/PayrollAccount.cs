using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A payroll account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayrollAccount>))]
public sealed record PayrollAccount : OpenStringEnum<PayrollAccount>
{
    private PayrollAccount(string value) : base(value)
    {
    }

    public static readonly PayrollAccount Payroll = new("payroll");

    public TResult Match<TResult>(Func<TResult> onPayroll, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payroll => onPayroll(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayroll, Action<string> otherwise)
    {
        if (this == Payroll) onPayroll();
        else otherwise(Value);
    }
}
