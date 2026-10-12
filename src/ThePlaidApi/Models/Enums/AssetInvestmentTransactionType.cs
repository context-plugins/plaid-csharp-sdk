using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Investment Transaction Type Enumerated derived by Vendor.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetInvestmentTransactionType>))]
public sealed record AssetInvestmentTransactionType : OpenStringEnum<AssetInvestmentTransactionType>
{
    private AssetInvestmentTransactionType(string value) : base(value)
    {
    }

    public static readonly AssetInvestmentTransactionType Buy = new("Buy");

    public static readonly AssetInvestmentTransactionType Sell = new("Sell");

    public static readonly AssetInvestmentTransactionType Dividends = new("Dividends");

    public static readonly AssetInvestmentTransactionType Interest = new("Interest");

    public static readonly AssetInvestmentTransactionType Transfers = new("Transfers");

    public static readonly AssetInvestmentTransactionType Reinvestments = new("Reinvestments");

    public static readonly AssetInvestmentTransactionType FundsReceived = new("FundsReceived");

    public static readonly AssetInvestmentTransactionType Other = new("Other");

    public TResult Match<TResult>(Func<TResult> onBuy,
        Func<TResult> onSell,
        Func<TResult> onDividends,
        Func<TResult> onInterest,
        Func<TResult> onTransfers,
        Func<TResult> onReinvestments,
        Func<TResult> onFundsReceived,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Buy => onBuy(),
            _ when this == Sell => onSell(),
            _ when this == Dividends => onDividends(),
            _ when this == Interest => onInterest(),
            _ when this == Transfers => onTransfers(),
            _ when this == Reinvestments => onReinvestments(),
            _ when this == FundsReceived => onFundsReceived(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuy,
        Action onSell,
        Action onDividends,
        Action onInterest,
        Action onTransfers,
        Action onReinvestments,
        Action onFundsReceived,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Buy) onBuy();
        else if (this == Sell) onSell();
        else if (this == Dividends) onDividends();
        else if (this == Interest) onInterest();
        else if (this == Transfers) onTransfers();
        else if (this == Reinvestments) onReinvestments();
        else if (this == FundsReceived) onFundsReceived();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
