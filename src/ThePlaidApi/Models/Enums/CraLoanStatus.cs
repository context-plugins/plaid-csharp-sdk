using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the loan.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanStatus>))]
public sealed record CraLoanStatus : OpenStringEnum<CraLoanStatus>
{
    private CraLoanStatus(string value) : base(value)
    {
    }

    public static readonly CraLoanStatus Approved = new("APPROVED");

    public static readonly CraLoanStatus Declined = new("DECLINED");

    public static readonly CraLoanStatus Booked = new("BOOKED");

    public static readonly CraLoanStatus Current = new("CURRENT");

    public static readonly CraLoanStatus Delinquent = new("DELINQUENT");

    public static readonly CraLoanStatus Default = new("DEFAULT");

    public static readonly CraLoanStatus ChargedOff = new("CHARGED_OFF");

    public static readonly CraLoanStatus Transferred = new("TRANSFERRED");

    public static readonly CraLoanStatus PaidOff = new("PAID_OFF");

    public static readonly CraLoanStatus Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onApproved,
        Func<TResult> onDeclined,
        Func<TResult> onBooked,
        Func<TResult> onCurrent,
        Func<TResult> onDelinquent,
        Func<TResult> onDefault,
        Func<TResult> onChargedOff,
        Func<TResult> onTransferred,
        Func<TResult> onPaidOff,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Approved => onApproved(),
            _ when this == Declined => onDeclined(),
            _ when this == Booked => onBooked(),
            _ when this == Current => onCurrent(),
            _ when this == Delinquent => onDelinquent(),
            _ when this == Default => onDefault(),
            _ when this == ChargedOff => onChargedOff(),
            _ when this == Transferred => onTransferred(),
            _ when this == PaidOff => onPaidOff(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onApproved,
        Action onDeclined,
        Action onBooked,
        Action onCurrent,
        Action onDelinquent,
        Action onDefault,
        Action onChargedOff,
        Action onTransferred,
        Action onPaidOff,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Approved) onApproved();
        else if (this == Declined) onDeclined();
        else if (this == Booked) onBooked();
        else if (this == Current) onCurrent();
        else if (this == Delinquent) onDelinquent();
        else if (this == Default) onDefault();
        else if (this == ChargedOff) onChargedOff();
        else if (this == Transferred) onTransferred();
        else if (this == PaidOff) onPaidOff();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
