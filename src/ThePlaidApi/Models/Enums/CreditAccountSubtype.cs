using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for credit accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-credit">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditAccountSubtype>))]
public sealed record CreditAccountSubtype : OpenStringEnum<CreditAccountSubtype>
{
    private CreditAccountSubtype(string value) : base(value)
    {
    }

    public static readonly CreditAccountSubtype CreditCard = new("credit card");

    public static readonly CreditAccountSubtype Paypal = new("paypal");

    public static readonly CreditAccountSubtype All = new("all");

    public TResult Match<TResult>(Func<TResult> onCreditCard,
        Func<TResult> onPaypal,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreditCard => onCreditCard(),
            _ when this == Paypal => onPaypal(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreditCard, Action onPaypal, Action onAll, Action<string> otherwise)
    {
        if (this == CreditCard) onCreditCard();
        else if (this == Paypal) onPaypal();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
