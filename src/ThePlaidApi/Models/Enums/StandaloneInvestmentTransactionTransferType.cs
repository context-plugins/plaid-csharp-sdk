using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StandaloneInvestmentTransactionTransferType>))]
public sealed record StandaloneInvestmentTransactionTransferType : OpenStringEnum<StandaloneInvestmentTransactionTransferType>
{
    private StandaloneInvestmentTransactionTransferType(string value) : base(value)
    {
    }

    public static readonly StandaloneInvestmentTransactionTransferType Assignment = new("assignment");

    public static readonly StandaloneInvestmentTransactionTransferType Adjustment = new("adjustment");

    public static readonly StandaloneInvestmentTransactionTransferType Exercise = new("exercise");

    public static readonly StandaloneInvestmentTransactionTransferType Expire = new("expire");

    public static readonly StandaloneInvestmentTransactionTransferType Merger = new("merger");

    public static readonly StandaloneInvestmentTransactionTransferType Request = new("request");

    public static readonly StandaloneInvestmentTransactionTransferType Send = new("send");

    public static readonly StandaloneInvestmentTransactionTransferType SpinOff = new("spin off");

    public static readonly StandaloneInvestmentTransactionTransferType Split = new("split");

    public static readonly StandaloneInvestmentTransactionTransferType Trade = new("trade");

    public static readonly StandaloneInvestmentTransactionTransferType Transfer = new("transfer");

    public TResult Match<TResult>(Func<TResult> onAssignment,
        Func<TResult> onAdjustment,
        Func<TResult> onExercise,
        Func<TResult> onExpire,
        Func<TResult> onMerger,
        Func<TResult> onRequest,
        Func<TResult> onSend,
        Func<TResult> onSpinOff,
        Func<TResult> onSplit,
        Func<TResult> onTrade,
        Func<TResult> onTransfer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assignment => onAssignment(),
            _ when this == Adjustment => onAdjustment(),
            _ when this == Exercise => onExercise(),
            _ when this == Expire => onExpire(),
            _ when this == Merger => onMerger(),
            _ when this == Request => onRequest(),
            _ when this == Send => onSend(),
            _ when this == SpinOff => onSpinOff(),
            _ when this == Split => onSplit(),
            _ when this == Trade => onTrade(),
            _ when this == Transfer => onTransfer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssignment,
        Action onAdjustment,
        Action onExercise,
        Action onExpire,
        Action onMerger,
        Action onRequest,
        Action onSend,
        Action onSpinOff,
        Action onSplit,
        Action onTrade,
        Action onTransfer,
        Action<string> otherwise)
    {
        if (this == Assignment) onAssignment();
        else if (this == Adjustment) onAdjustment();
        else if (this == Exercise) onExercise();
        else if (this == Expire) onExpire();
        else if (this == Merger) onMerger();
        else if (this == Request) onRequest();
        else if (this == Send) onSend();
        else if (this == SpinOff) onSpinOff();
        else if (this == Split) onSplit();
        else if (this == Trade) onTrade();
        else if (this == Transfer) onTransfer();
        else otherwise(Value);
    }
}
