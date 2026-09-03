using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A binary match indicator specifying whether the country that issued the provided document matches the country that the user separately provided to Plaid.
/// <para>
/// Note: You can configure whether a <c>no_match</c> on <c>issuing_country</c> fails the <c>documentary_verification</c> by editing your Plaid Template.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IssuingCountry>))]
public sealed record IssuingCountry : StringEnum<IssuingCountry>
{
    private IssuingCountry(string value) : base(value)
    {
    }

    public static readonly IssuingCountry Match = new("match");

    public static readonly IssuingCountry NoMatch = new("no_match");

    public static IssuingCountry FromValue(string value) => FromValueCore(value);
}
