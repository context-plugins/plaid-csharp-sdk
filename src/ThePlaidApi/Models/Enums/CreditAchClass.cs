using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the use case of the transfer. Required for transfers on an ACH network.
/// <para>
/// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
/// </para>
/// <para>
/// <c>"ppd"</c> - Prearranged Payment or Deposit - The transfer is part of a pre-existing relationship with a consumer. Authorization was obtained in writing either in person or via an electronic document signing, e.g. Docusign, by the consumer. Can be used for credits or debits.
/// </para>
/// <para>
/// <c>"web"</c> - Internet-Initiated Entry. The transfer debits a consumer's bank account. Authorization from the consumer is obtained over the Internet (e.g. a web or mobile application). Can be used for single debits or recurring debits.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditAchClass>))]
public sealed record CreditAchClass : OpenStringEnum<CreditAchClass>
{
    private CreditAchClass(string value) : base(value)
    {
    }

    public static readonly CreditAchClass Ccd = new("ccd");

    public static readonly CreditAchClass Ppd = new("ppd");

    public static readonly CreditAchClass Web = new("web");

    public TResult Match<TResult>(Func<TResult> onCcd,
        Func<TResult> onPpd,
        Func<TResult> onWeb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ccd => onCcd(),
            _ when this == Ppd => onPpd(),
            _ when this == Web => onWeb(),
            _ => otherwise(Value)
        };

    public void Match(Action onCcd, Action onPpd, Action onWeb, Action<string> otherwise)
    {
        if (this == Ccd) onCcd();
        else if (this == Ppd) onPpd();
        else if (this == Web) onWeb();
        else otherwise(Value);
    }
}
