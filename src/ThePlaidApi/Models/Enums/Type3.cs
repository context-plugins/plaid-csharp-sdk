using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the repayment plan.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 ExtendedGraduated = new("extended graduated");

    public static readonly Type3 ExtendedStandard = new("extended standard");

    public static readonly Type3 Graduated = new("graduated");

    public static readonly Type3 IncomeContingentRepayment = new("income-contingent repayment");

    public static readonly Type3 IncomeBasedRepayment = new("income-based repayment");

    public static readonly Type3 IncomeSensitiveRepayment = new("income-sensitive repayment");

    public static readonly Type3 InterestOnly = new("interest only");

    public static readonly Type3 Other = new("other");

    public static readonly Type3 PayAsYouEarn = new("pay as you earn");

    public static readonly Type3 RevisedPayAsYouEarn = new("revised pay as you earn");

    public static readonly Type3 Standard = new("standard");

    public static readonly Type3 SavingOnAValuableEducation = new("saving on a valuable education");

    public TResult Match<TResult>(Func<TResult> onExtendedGraduated,
        Func<TResult> onExtendedStandard,
        Func<TResult> onGraduated,
        Func<TResult> onIncomeContingentRepayment,
        Func<TResult> onIncomeBasedRepayment,
        Func<TResult> onIncomeSensitiveRepayment,
        Func<TResult> onInterestOnly,
        Func<TResult> onOther,
        Func<TResult> onPayAsYouEarn,
        Func<TResult> onRevisedPayAsYouEarn,
        Func<TResult> onStandard,
        Func<TResult> onSavingOnAValuableEducation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ExtendedGraduated => onExtendedGraduated(),
            _ when this == ExtendedStandard => onExtendedStandard(),
            _ when this == Graduated => onGraduated(),
            _ when this == IncomeContingentRepayment => onIncomeContingentRepayment(),
            _ when this == IncomeBasedRepayment => onIncomeBasedRepayment(),
            _ when this == IncomeSensitiveRepayment => onIncomeSensitiveRepayment(),
            _ when this == InterestOnly => onInterestOnly(),
            _ when this == Other => onOther(),
            _ when this == PayAsYouEarn => onPayAsYouEarn(),
            _ when this == RevisedPayAsYouEarn => onRevisedPayAsYouEarn(),
            _ when this == Standard => onStandard(),
            _ when this == SavingOnAValuableEducation => onSavingOnAValuableEducation(),
            _ => otherwise(Value)
        };

    public void Match(Action onExtendedGraduated,
        Action onExtendedStandard,
        Action onGraduated,
        Action onIncomeContingentRepayment,
        Action onIncomeBasedRepayment,
        Action onIncomeSensitiveRepayment,
        Action onInterestOnly,
        Action onOther,
        Action onPayAsYouEarn,
        Action onRevisedPayAsYouEarn,
        Action onStandard,
        Action onSavingOnAValuableEducation,
        Action<string> otherwise)
    {
        if (this == ExtendedGraduated) onExtendedGraduated();
        else if (this == ExtendedStandard) onExtendedStandard();
        else if (this == Graduated) onGraduated();
        else if (this == IncomeContingentRepayment) onIncomeContingentRepayment();
        else if (this == IncomeBasedRepayment) onIncomeBasedRepayment();
        else if (this == IncomeSensitiveRepayment) onIncomeSensitiveRepayment();
        else if (this == InterestOnly) onInterestOnly();
        else if (this == Other) onOther();
        else if (this == PayAsYouEarn) onPayAsYouEarn();
        else if (this == RevisedPayAsYouEarn) onRevisedPayAsYouEarn();
        else if (this == Standard) onStandard();
        else if (this == SavingOnAValuableEducation) onSavingOnAValuableEducation();
        else otherwise(Value);
    }
}
