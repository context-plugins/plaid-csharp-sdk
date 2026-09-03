using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// ISO-3166-1 alpha-2 country code standard.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CountryCode>))]
public sealed record CountryCode : StringEnum<CountryCode>
{
    private CountryCode(string value) : base(value)
    {
    }

    public static readonly CountryCode Us = new("US");

    public static readonly CountryCode Gb = new("GB");

    public static readonly CountryCode Es = new("ES");

    public static readonly CountryCode Nl = new("NL");

    public static readonly CountryCode Fr = new("FR");

    public static readonly CountryCode Ie = new("IE");

    public static readonly CountryCode Ca = new("CA");

    public static readonly CountryCode De = new("DE");

    public static readonly CountryCode It = new("IT");

    public static readonly CountryCode Pl = new("PL");

    public static readonly CountryCode Dk = new("DK");

    public static readonly CountryCode No = new("NO");

    public static readonly CountryCode Se = new("SE");

    public static readonly CountryCode Ee = new("EE");

    public static readonly CountryCode Lt = new("LT");

    public static readonly CountryCode Lv = new("LV");

    public static readonly CountryCode Pt = new("PT");

    public static readonly CountryCode Be = new("BE");

    public static readonly CountryCode At = new("AT");

    public static readonly CountryCode Fi = new("FI");

    public static CountryCode FromValue(string value) => FromValueCore(value);
}
