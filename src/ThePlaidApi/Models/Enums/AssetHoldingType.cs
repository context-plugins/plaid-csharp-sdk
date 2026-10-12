using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of holding (e.g. bond, stock, crypto, other)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetHoldingType>))]
public sealed record AssetHoldingType : OpenStringEnum<AssetHoldingType>
{
    private AssetHoldingType(string value) : base(value)
    {
    }

    public static readonly AssetHoldingType Bond = new("Bond");

    public static readonly AssetHoldingType Stock = new("Stock");

    public static readonly AssetHoldingType Crypto = new("Crypto");

    public static readonly AssetHoldingType Other = new("Other");

    public TResult Match<TResult>(Func<TResult> onBond,
        Func<TResult> onStock,
        Func<TResult> onCrypto,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bond => onBond(),
            _ when this == Stock => onStock(),
            _ when this == Crypto => onCrypto(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBond, Action onStock, Action onCrypto, Action onOther, Action<string> otherwise)
    {
        if (this == Bond) onBond();
        else if (this == Stock) onStock();
        else if (this == Crypto) onCrypto();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
