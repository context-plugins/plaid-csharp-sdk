using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An ISO-4217 currency code.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IsoCurrencyCode1>))]
public sealed record IsoCurrencyCode1 : StringEnum<IsoCurrencyCode1>
{
    private IsoCurrencyCode1(string value) : base(value)
    {
    }

    public static readonly IsoCurrencyCode1 Usd = new("USD");

    public static IsoCurrencyCode1 FromValue(string value) => FromValueCore(value);
}
