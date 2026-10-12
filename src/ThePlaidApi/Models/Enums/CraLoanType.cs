using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of loan the user applied for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanType>))]
public sealed record CraLoanType : OpenStringEnum<CraLoanType>
{
    private CraLoanType(string value) : base(value)
    {
    }

    public static readonly CraLoanType Personal = new("PERSONAL");

    public static readonly CraLoanType CreditCard = new("CREDIT_CARD");

    public static readonly CraLoanType Business = new("BUSINESS");

    public static readonly CraLoanType Mortgage = new("MORTGAGE");

    public static readonly CraLoanType Auto = new("AUTO");

    public static readonly CraLoanType Payday = new("PAYDAY");

    public static readonly CraLoanType Student = new("STUDENT");

    public static readonly CraLoanType HomeEquity = new("HOME_EQUITY");

    public static readonly CraLoanType Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onPersonal,
        Func<TResult> onCreditCard,
        Func<TResult> onBusiness,
        Func<TResult> onMortgage,
        Func<TResult> onAuto,
        Func<TResult> onPayday,
        Func<TResult> onStudent,
        Func<TResult> onHomeEquity,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Personal => onPersonal(),
            _ when this == CreditCard => onCreditCard(),
            _ when this == Business => onBusiness(),
            _ when this == Mortgage => onMortgage(),
            _ when this == Auto => onAuto(),
            _ when this == Payday => onPayday(),
            _ when this == Student => onStudent(),
            _ when this == HomeEquity => onHomeEquity(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onPersonal,
        Action onCreditCard,
        Action onBusiness,
        Action onMortgage,
        Action onAuto,
        Action onPayday,
        Action onStudent,
        Action onHomeEquity,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Personal) onPersonal();
        else if (this == CreditCard) onCreditCard();
        else if (this == Business) onBusiness();
        else if (this == Mortgage) onMortgage();
        else if (this == Auto) onAuto();
        else if (this == Payday) onPayday();
        else if (this == Student) onStudent();
        else if (this == HomeEquity) onHomeEquity();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
