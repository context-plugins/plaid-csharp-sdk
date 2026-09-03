using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the use case of the transfer. Required for transfers on an ACH network. For more details, see <see href="https://plaid.com/docs/transfer/creating-transfers/#ach-sec-codes">ACH SEC codes</see>.
/// <para>
/// Codes supported for credits: <c>ccd</c>, <c>ppd</c>
/// Codes supported for debits: <c>ccd</c>, <c>ppd</c>, <c>tel</c>, <c>web</c>
/// </para>
/// <para>
/// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
/// </para>
/// <para>
/// <c>"ppd"</c> - Prearranged Payment or Deposit - The transfer is part of a pre-existing relationship with a consumer. Authorization was obtained in writing either in person or via an electronic document signing, e.g. Docusign, by the consumer. Can be used for credits or debits.
/// </para>
/// <para>
/// <c>"web"</c> - Internet-Initiated Entry. The transfer debits a consumer's bank account. Authorization from the consumer is obtained over the Internet (e.g. a web or mobile application). Can be used for single debits or recurring debits.
/// </para>
/// <para>
/// <c>"tel"</c> - Telephone-Initiated Entry. The transfer debits a consumer. Debit authorization has been received orally over the telephone via a recorded call.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AchClass>))]
public sealed record AchClass : StringEnum<AchClass>
{
    private AchClass(string value) : base(value)
    {
    }

    public static readonly AchClass Ccd = new("ccd");

    public static readonly AchClass Ppd = new("ppd");

    public static readonly AchClass Tel = new("tel");

    public static readonly AchClass Web = new("web");

    public static AchClass FromValue(string value) => FromValueCore(value);
}
