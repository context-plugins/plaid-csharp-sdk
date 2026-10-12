using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A credit card type account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditAccount>))]
public sealed record CreditAccount : OpenStringEnum<CreditAccount>
{
    private CreditAccount(string value) : base(value)
    {
    }

    public static readonly CreditAccount CreditCard = new("credit card");

    public static readonly CreditAccount Paypal = new("paypal");

    public TResult Match<TResult>(Func<TResult> onCreditCard,
        Func<TResult> onPaypal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreditCard => onCreditCard(),
            _ when this == Paypal => onPaypal(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreditCard, Action onPaypal, Action<string> otherwise)
    {
        if (this == CreditCard) onCreditCard();
        else if (this == Paypal) onPaypal();
        else otherwise(Value);
    }
}
