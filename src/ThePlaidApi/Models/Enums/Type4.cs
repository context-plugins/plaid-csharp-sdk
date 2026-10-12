using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : OpenStringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Payout = new("PAYOUT");

    public static readonly Type4 Return = new("RETURN");

    public static readonly Type4 Refund = new("REFUND");

    public static readonly Type4 FundsSweep = new("FUNDS_SWEEP");

    public TResult Match<TResult>(Func<TResult> onPayout,
        Func<TResult> onReturn,
        Func<TResult> onRefund,
        Func<TResult> onFundsSweep,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payout => onPayout(),
            _ when this == Return => onReturn(),
            _ when this == Refund => onRefund(),
            _ when this == FundsSweep => onFundsSweep(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayout, Action onReturn, Action onRefund, Action onFundsSweep, Action<string> otherwise)
    {
        if (this == Payout) onPayout();
        else if (this == Return) onReturn();
        else if (this == Refund) onRefund();
        else if (this == FundsSweep) onFundsSweep();
        else otherwise(Value);
    }
}
