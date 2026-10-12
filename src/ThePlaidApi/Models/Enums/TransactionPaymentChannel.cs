using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The channel used to make a payment.
/// <c>online:</c> transactions that took place online.
/// <para>
/// <c>in store:</c> transactions that were made at a physical location.
/// </para>
/// <para>
/// <c>other:</c> transactions that relate to banks, e.g. fees or deposits.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionPaymentChannel>))]
public sealed record TransactionPaymentChannel : OpenStringEnum<TransactionPaymentChannel>
{
    private TransactionPaymentChannel(string value) : base(value)
    {
    }

    public static readonly TransactionPaymentChannel Online = new("online");

    public static readonly TransactionPaymentChannel InStore = new("in store");

    public static readonly TransactionPaymentChannel Other = new("other");

    public TResult Match<TResult>(Func<TResult> onOnline,
        Func<TResult> onInStore,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Online => onOnline(),
            _ when this == InStore => onInStore(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnline, Action onInStore, Action onOther, Action<string> otherwise)
    {
        if (this == Online) onOnline();
        else if (this == InStore) onInStore();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
