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
public sealed record CreditAchClass : StringEnum<CreditAchClass>
{
    private CreditAchClass(string value) : base(value)
    {
    }

    public static readonly CreditAchClass Ccd = new("ccd");

    public static readonly CreditAchClass Ppd = new("ppd");

    public static readonly CreditAchClass Web = new("web");

    public static CreditAchClass FromValue(string value) => FromValueCore(value);
}
