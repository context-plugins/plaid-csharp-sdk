using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An ISO-4217 currency code, used with e-wallets and transactions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IsoCurrencyCode>))]
public sealed record IsoCurrencyCode : OpenStringEnum<IsoCurrencyCode>
{
    private IsoCurrencyCode(string value) : base(value)
    {
    }

    public static readonly IsoCurrencyCode Gbp = new("GBP");

    public static readonly IsoCurrencyCode Eur = new("EUR");

    public TResult Match<TResult>(Func<TResult> onGbp, Func<TResult> onEur, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gbp => onGbp(),
            _ when this == Eur => onEur(),
            _ => otherwise(Value)
        };

    public void Match(Action onGbp, Action onEur, Action<string> otherwise)
    {
        if (this == Gbp) onGbp();
        else if (this == Eur) onEur();
        else otherwise(Value);
    }
}
