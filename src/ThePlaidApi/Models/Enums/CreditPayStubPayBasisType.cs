using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The explicit pay basis on the paystub (if present).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditPayStubPayBasisType>))]
public sealed record CreditPayStubPayBasisType : OpenStringEnum<CreditPayStubPayBasisType>
{
    private CreditPayStubPayBasisType(string value) : base(value)
    {
    }

    public static readonly CreditPayStubPayBasisType Salary = new("SALARY");

    public static readonly CreditPayStubPayBasisType Hourly = new("HOURLY");

    public static readonly CreditPayStubPayBasisType Commission = new("COMMISSION");

    public TResult Match<TResult>(Func<TResult> onSalary,
        Func<TResult> onHourly,
        Func<TResult> onCommission,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Salary => onSalary(),
            _ when this == Hourly => onHourly(),
            _ when this == Commission => onCommission(),
            _ => otherwise(Value)
        };

    public void Match(Action onSalary, Action onHourly, Action onCommission, Action<string> otherwise)
    {
        if (this == Salary) onSalary();
        else if (this == Hourly) onHourly();
        else if (this == Commission) onCommission();
        else otherwise(Value);
    }
}
