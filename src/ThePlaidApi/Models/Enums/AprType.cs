using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of balance to which the APR applies.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AprType>))]
public sealed record AprType : OpenStringEnum<AprType>
{
    private AprType(string value) : base(value)
    {
    }

    public static readonly AprType BalanceTransferApr = new("balance_transfer_apr");

    public static readonly AprType CashApr = new("cash_apr");

    public static readonly AprType PurchaseApr = new("purchase_apr");

    public static readonly AprType Special = new("special");

    public TResult Match<TResult>(Func<TResult> onBalanceTransferApr,
        Func<TResult> onCashApr,
        Func<TResult> onPurchaseApr,
        Func<TResult> onSpecial,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BalanceTransferApr => onBalanceTransferApr(),
            _ when this == CashApr => onCashApr(),
            _ when this == PurchaseApr => onPurchaseApr(),
            _ when this == Special => onSpecial(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalanceTransferApr,
        Action onCashApr,
        Action onPurchaseApr,
        Action onSpecial,
        Action<string> otherwise)
    {
        if (this == BalanceTransferApr) onBalanceTransferApr();
        else if (this == CashApr) onCashApr();
        else if (this == PurchaseApr) onPurchaseApr();
        else if (this == Special) onSpecial();
        else otherwise(Value);
    }
}
