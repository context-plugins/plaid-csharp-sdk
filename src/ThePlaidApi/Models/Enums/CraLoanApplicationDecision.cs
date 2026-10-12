using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The decision of the loan application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanApplicationDecision>))]
public sealed record CraLoanApplicationDecision : OpenStringEnum<CraLoanApplicationDecision>
{
    private CraLoanApplicationDecision(string value) : base(value)
    {
    }

    public static readonly CraLoanApplicationDecision Approved = new("APPROVED");

    public static readonly CraLoanApplicationDecision Declined = new("DECLINED");

    public static readonly CraLoanApplicationDecision Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onApproved,
        Func<TResult> onDeclined,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Approved => onApproved(),
            _ when this == Declined => onDeclined(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onApproved, Action onDeclined, Action onOther, Action<string> otherwise)
    {
        if (this == Approved) onApproved();
        else if (this == Declined) onDeclined();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
