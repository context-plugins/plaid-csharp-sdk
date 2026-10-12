using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A loan type account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanAccount>))]
public sealed record LoanAccount : OpenStringEnum<LoanAccount>
{
    private LoanAccount(string value) : base(value)
    {
    }

    public static readonly LoanAccount Auto = new("auto");

    public static readonly LoanAccount Business = new("business");

    public static readonly LoanAccount Commercial = new("commercial");

    public static readonly LoanAccount Construction = new("construction");

    public static readonly LoanAccount Consumer = new("consumer");

    public static readonly LoanAccount HomeEquity = new("home equity");

    public static readonly LoanAccount LineOfCredit = new("line of credit");

    public static readonly LoanAccount Loan = new("loan");

    public static readonly LoanAccount Mortgage = new("mortgage");

    public static readonly LoanAccount Other = new("other");

    public static readonly LoanAccount Overdraft = new("overdraft");

    public static readonly LoanAccount Student = new("student");

    public TResult Match<TResult>(Func<TResult> onAuto,
        Func<TResult> onBusiness,
        Func<TResult> onCommercial,
        Func<TResult> onConstruction,
        Func<TResult> onConsumer,
        Func<TResult> onHomeEquity,
        Func<TResult> onLineOfCredit,
        Func<TResult> onLoan,
        Func<TResult> onMortgage,
        Func<TResult> onOther,
        Func<TResult> onOverdraft,
        Func<TResult> onStudent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Auto => onAuto(),
            _ when this == Business => onBusiness(),
            _ when this == Commercial => onCommercial(),
            _ when this == Construction => onConstruction(),
            _ when this == Consumer => onConsumer(),
            _ when this == HomeEquity => onHomeEquity(),
            _ when this == LineOfCredit => onLineOfCredit(),
            _ when this == Loan => onLoan(),
            _ when this == Mortgage => onMortgage(),
            _ when this == Other => onOther(),
            _ when this == Overdraft => onOverdraft(),
            _ when this == Student => onStudent(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuto,
        Action onBusiness,
        Action onCommercial,
        Action onConstruction,
        Action onConsumer,
        Action onHomeEquity,
        Action onLineOfCredit,
        Action onLoan,
        Action onMortgage,
        Action onOther,
        Action onOverdraft,
        Action onStudent,
        Action<string> otherwise)
    {
        if (this == Auto) onAuto();
        else if (this == Business) onBusiness();
        else if (this == Commercial) onCommercial();
        else if (this == Construction) onConstruction();
        else if (this == Consumer) onConsumer();
        else if (this == HomeEquity) onHomeEquity();
        else if (this == LineOfCredit) onLineOfCredit();
        else if (this == Loan) onLoan();
        else if (this == Mortgage) onMortgage();
        else if (this == Other) onOther();
        else if (this == Overdraft) onOverdraft();
        else if (this == Student) onStudent();
        else otherwise(Value);
    }
}
