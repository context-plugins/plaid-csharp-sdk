using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used. For Poland, Denmark, Sweden and Norway, only the local currency is currently supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentAmountCurrency>))]
public sealed record PaymentAmountCurrency : OpenStringEnum<PaymentAmountCurrency>
{
    private PaymentAmountCurrency(string value) : base(value)
    {
    }

    public static readonly PaymentAmountCurrency Gbp = new("GBP");

    public static readonly PaymentAmountCurrency Eur = new("EUR");

    public static readonly PaymentAmountCurrency Pln = new("PLN");

    public static readonly PaymentAmountCurrency Sek = new("SEK");

    public static readonly PaymentAmountCurrency Dkk = new("DKK");

    public static readonly PaymentAmountCurrency Nok = new("NOK");

    public TResult Match<TResult>(Func<TResult> onGbp,
        Func<TResult> onEur,
        Func<TResult> onPln,
        Func<TResult> onSek,
        Func<TResult> onDkk,
        Func<TResult> onNok,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gbp => onGbp(),
            _ when this == Eur => onEur(),
            _ when this == Pln => onPln(),
            _ when this == Sek => onSek(),
            _ when this == Dkk => onDkk(),
            _ when this == Nok => onNok(),
            _ => otherwise(Value)
        };

    public void Match(Action onGbp,
        Action onEur,
        Action onPln,
        Action onSek,
        Action onDkk,
        Action onNok,
        Action<string> otherwise)
    {
        if (this == Gbp) onGbp();
        else if (this == Eur) onEur();
        else if (this == Pln) onPln();
        else if (this == Sek) onSek();
        else if (this == Dkk) onDkk();
        else if (this == Nok) onNok();
        else otherwise(Value);
    }
}
