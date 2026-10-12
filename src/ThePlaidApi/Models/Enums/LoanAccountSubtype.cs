using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for loan accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-loan">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanAccountSubtype>))]
public sealed record LoanAccountSubtype : OpenStringEnum<LoanAccountSubtype>
{
    private LoanAccountSubtype(string value) : base(value)
    {
    }

    public static readonly LoanAccountSubtype Auto = new("auto");

    public static readonly LoanAccountSubtype Business = new("business");

    public static readonly LoanAccountSubtype Commercial = new("commercial");

    public static readonly LoanAccountSubtype Construction = new("construction");

    public static readonly LoanAccountSubtype Consumer = new("consumer");

    public static readonly LoanAccountSubtype HomeEquity = new("home equity");

    public static readonly LoanAccountSubtype Loan = new("loan");

    public static readonly LoanAccountSubtype Mortgage = new("mortgage");

    public static readonly LoanAccountSubtype Overdraft = new("overdraft");

    public static readonly LoanAccountSubtype LineOfCredit = new("line of credit");

    public static readonly LoanAccountSubtype Student = new("student");

    public static readonly LoanAccountSubtype Other = new("other");

    public static readonly LoanAccountSubtype All = new("all");

    public TResult Match<TResult>(Func<TResult> onAuto,
        Func<TResult> onBusiness,
        Func<TResult> onCommercial,
        Func<TResult> onConstruction,
        Func<TResult> onConsumer,
        Func<TResult> onHomeEquity,
        Func<TResult> onLoan,
        Func<TResult> onMortgage,
        Func<TResult> onOverdraft,
        Func<TResult> onLineOfCredit,
        Func<TResult> onStudent,
        Func<TResult> onOther,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Auto => onAuto(),
            _ when this == Business => onBusiness(),
            _ when this == Commercial => onCommercial(),
            _ when this == Construction => onConstruction(),
            _ when this == Consumer => onConsumer(),
            _ when this == HomeEquity => onHomeEquity(),
            _ when this == Loan => onLoan(),
            _ when this == Mortgage => onMortgage(),
            _ when this == Overdraft => onOverdraft(),
            _ when this == LineOfCredit => onLineOfCredit(),
            _ when this == Student => onStudent(),
            _ when this == Other => onOther(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuto,
        Action onBusiness,
        Action onCommercial,
        Action onConstruction,
        Action onConsumer,
        Action onHomeEquity,
        Action onLoan,
        Action onMortgage,
        Action onOverdraft,
        Action onLineOfCredit,
        Action onStudent,
        Action onOther,
        Action onAll,
        Action<string> otherwise)
    {
        if (this == Auto) onAuto();
        else if (this == Business) onBusiness();
        else if (this == Commercial) onCommercial();
        else if (this == Construction) onConstruction();
        else if (this == Consumer) onConsumer();
        else if (this == HomeEquity) onHomeEquity();
        else if (this == Loan) onLoan();
        else if (this == Mortgage) onMortgage();
        else if (this == Overdraft) onOverdraft();
        else if (this == LineOfCredit) onLineOfCredit();
        else if (this == Student) onStudent();
        else if (this == Other) onOther();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
