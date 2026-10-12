using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income category for a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourceCategory>))]
public sealed record UserStatedIncomeSourceCategory : OpenStringEnum<UserStatedIncomeSourceCategory>
{
    private UserStatedIncomeSourceCategory(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourceCategory Other = new("OTHER");

    public static readonly UserStatedIncomeSourceCategory Salary = new("SALARY");

    public static readonly UserStatedIncomeSourceCategory Unemployment = new("UNEMPLOYMENT");

    public static readonly UserStatedIncomeSourceCategory Cash = new("CASH");

    public static readonly UserStatedIncomeSourceCategory GigEconomy = new("GIG_ECONOMY");

    public static readonly UserStatedIncomeSourceCategory Rental = new("RENTAL");

    public static readonly UserStatedIncomeSourceCategory ChildSupport = new("CHILD_SUPPORT");

    public static readonly UserStatedIncomeSourceCategory Military = new("MILITARY");

    public static readonly UserStatedIncomeSourceCategory Retirement = new("RETIREMENT");

    public static readonly UserStatedIncomeSourceCategory LongTermDisability = new("LONG_TERM_DISABILITY");

    public static readonly UserStatedIncomeSourceCategory BankInterest = new("BANK_INTEREST");

    public TResult Match<TResult>(Func<TResult> onOther,
        Func<TResult> onSalary,
        Func<TResult> onUnemployment,
        Func<TResult> onCash,
        Func<TResult> onGigEconomy,
        Func<TResult> onRental,
        Func<TResult> onChildSupport,
        Func<TResult> onMilitary,
        Func<TResult> onRetirement,
        Func<TResult> onLongTermDisability,
        Func<TResult> onBankInterest,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Other => onOther(),
            _ when this == Salary => onSalary(),
            _ when this == Unemployment => onUnemployment(),
            _ when this == Cash => onCash(),
            _ when this == GigEconomy => onGigEconomy(),
            _ when this == Rental => onRental(),
            _ when this == ChildSupport => onChildSupport(),
            _ when this == Military => onMilitary(),
            _ when this == Retirement => onRetirement(),
            _ when this == LongTermDisability => onLongTermDisability(),
            _ when this == BankInterest => onBankInterest(),
            _ => otherwise(Value)
        };

    public void Match(Action onOther,
        Action onSalary,
        Action onUnemployment,
        Action onCash,
        Action onGigEconomy,
        Action onRental,
        Action onChildSupport,
        Action onMilitary,
        Action onRetirement,
        Action onLongTermDisability,
        Action onBankInterest,
        Action<string> otherwise)
    {
        if (this == Other) onOther();
        else if (this == Salary) onSalary();
        else if (this == Unemployment) onUnemployment();
        else if (this == Cash) onCash();
        else if (this == GigEconomy) onGigEconomy();
        else if (this == Rental) onRental();
        else if (this == ChildSupport) onChildSupport();
        else if (this == Military) onMilitary();
        else if (this == Retirement) onRetirement();
        else if (this == LongTermDisability) onLongTermDisability();
        else if (this == BankInterest) onBankInterest();
        else otherwise(Value);
    }
}
