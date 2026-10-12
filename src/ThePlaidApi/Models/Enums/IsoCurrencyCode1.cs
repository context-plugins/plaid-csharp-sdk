using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An ISO-4217 currency code.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IsoCurrencyCode1>))]
public sealed record IsoCurrencyCode1 : OpenStringEnum<IsoCurrencyCode1>
{
    private IsoCurrencyCode1(string value) : base(value)
    {
    }

    public static readonly IsoCurrencyCode1 Usd = new("USD");

    public TResult Match<TResult>(Func<TResult> onUsd, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Usd => onUsd(),
            _ => otherwise(Value)
        };

    public void Match(Action onUsd, Action<string> otherwise)
    {
        if (this == Usd) onUsd();
        else otherwise(Value);
    }
}
