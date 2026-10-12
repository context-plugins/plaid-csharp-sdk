using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Selling an investment
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SellType>))]
public sealed record SellType : OpenStringEnum<SellType>
{
    private SellType(string value) : base(value)
    {
    }

    public static readonly SellType Distribution = new("distribution");

    public static readonly SellType Exercise = new("exercise");

    public static readonly SellType Sell = new("sell");

    public static readonly SellType SellShort = new("sell short");

    public TResult Match<TResult>(Func<TResult> onDistribution,
        Func<TResult> onExercise,
        Func<TResult> onSell,
        Func<TResult> onSellShort,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Distribution => onDistribution(),
            _ when this == Exercise => onExercise(),
            _ when this == Sell => onSell(),
            _ when this == SellShort => onSellShort(),
            _ => otherwise(Value)
        };

    public void Match(Action onDistribution,
        Action onExercise,
        Action onSell,
        Action onSellShort,
        Action<string> otherwise)
    {
        if (this == Distribution) onDistribution();
        else if (this == Exercise) onExercise();
        else if (this == Sell) onSell();
        else if (this == SellShort) onSellShort();
        else otherwise(Value);
    }
}
