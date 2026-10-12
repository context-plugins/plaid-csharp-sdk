using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Buying an investment
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BuyType>))]
public sealed record BuyType : OpenStringEnum<BuyType>
{
    private BuyType(string value) : base(value)
    {
    }

    public static readonly BuyType Assignment = new("assignment");

    public static readonly BuyType Contribution = new("contribution");

    public static readonly BuyType Buy = new("buy");

    public static readonly BuyType BuyToCover = new("buy to cover");

    public static readonly BuyType DividendReinvestment = new("dividend reinvestment");

    public static readonly BuyType InterestReinvestment = new("interest reinvestment");

    public static readonly BuyType LongTermCapitalGainReinvestment = new("long-term capital gain reinvestment");

    public static readonly BuyType ShortTermCapitalGainReinvestment = new("short-term capital gain reinvestment");

    public TResult Match<TResult>(Func<TResult> onAssignment,
        Func<TResult> onContribution,
        Func<TResult> onBuy,
        Func<TResult> onBuyToCover,
        Func<TResult> onDividendReinvestment,
        Func<TResult> onInterestReinvestment,
        Func<TResult> onLongTermCapitalGainReinvestment,
        Func<TResult> onShortTermCapitalGainReinvestment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assignment => onAssignment(),
            _ when this == Contribution => onContribution(),
            _ when this == Buy => onBuy(),
            _ when this == BuyToCover => onBuyToCover(),
            _ when this == DividendReinvestment => onDividendReinvestment(),
            _ when this == InterestReinvestment => onInterestReinvestment(),
            _ when this == LongTermCapitalGainReinvestment => onLongTermCapitalGainReinvestment(),
            _ when this == ShortTermCapitalGainReinvestment => onShortTermCapitalGainReinvestment(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssignment,
        Action onContribution,
        Action onBuy,
        Action onBuyToCover,
        Action onDividendReinvestment,
        Action onInterestReinvestment,
        Action onLongTermCapitalGainReinvestment,
        Action onShortTermCapitalGainReinvestment,
        Action<string> otherwise)
    {
        if (this == Assignment) onAssignment();
        else if (this == Contribution) onContribution();
        else if (this == Buy) onBuy();
        else if (this == BuyToCover) onBuyToCover();
        else if (this == DividendReinvestment) onDividendReinvestment();
        else if (this == InterestReinvestment) onInterestReinvestment();
        else if (this == LongTermCapitalGainReinvestment) onLongTermCapitalGainReinvestment();
        else if (this == ShortTermCapitalGainReinvestment) onShortTermCapitalGainReinvestment();
        else otherwise(Value);
    }
}
