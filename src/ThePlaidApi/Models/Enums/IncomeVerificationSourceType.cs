using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of source income data that users should be able to share
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationSourceType>))]
public sealed record IncomeVerificationSourceType : OpenStringEnum<IncomeVerificationSourceType>
{
    private IncomeVerificationSourceType(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationSourceType Bank = new("bank");

    public static readonly IncomeVerificationSourceType Payroll = new("payroll");

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
