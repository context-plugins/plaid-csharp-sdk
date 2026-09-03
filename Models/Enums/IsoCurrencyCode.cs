using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An ISO-4217 currency code, used with e-wallets and transactions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IsoCurrencyCode>))]
public sealed record IsoCurrencyCode : StringEnum<IsoCurrencyCode>
{
    private IsoCurrencyCode(string value) : base(value)
    {
    }

    public static readonly IsoCurrencyCode Gbp = new("GBP");

    public static readonly IsoCurrencyCode Eur = new("EUR");

    public static IsoCurrencyCode FromValue(string value) => FromValueCore(value);
}
