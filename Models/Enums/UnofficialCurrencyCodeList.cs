using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// List of unofficial currency codes
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UnofficialCurrencyCodeList>))]
public sealed record UnofficialCurrencyCodeList : StringEnum<UnofficialCurrencyCodeList>
{
    private UnofficialCurrencyCodeList(string value) : base(value)
    {
    }

    public static readonly UnofficialCurrencyCodeList Ada = new("ADA");

    public static readonly UnofficialCurrencyCodeList Bat = new("BAT");

    public static readonly UnofficialCurrencyCodeList Bch = new("BCH");

    public static readonly UnofficialCurrencyCodeList Bnb = new("BNB");

    public static readonly UnofficialCurrencyCodeList Btc = new("BTC");

    public static readonly UnofficialCurrencyCodeList Btg = new("BTG");

    public static readonly UnofficialCurrencyCodeList Bsv = new("BSV");

    public static readonly UnofficialCurrencyCodeList Cnh = new("CNH");

    public static readonly UnofficialCurrencyCodeList Dash = new("DASH");

    public static readonly UnofficialCurrencyCodeList Doge = new("DOGE");

    public static readonly UnofficialCurrencyCodeList Etc = new("ETC");

    public static readonly UnofficialCurrencyCodeList Eth = new("ETH");

    public static readonly UnofficialCurrencyCodeList Gbx = new("GBX");

    public static readonly UnofficialCurrencyCodeList Lsk = new("LSK");

    public static readonly UnofficialCurrencyCodeList Neo = new("NEO");

    public static readonly UnofficialCurrencyCodeList Omg = new("OMG");

    public static readonly UnofficialCurrencyCodeList Qtum = new("QTUM");

    public static readonly UnofficialCurrencyCodeList Usdt = new("USDT");

    public static readonly UnofficialCurrencyCodeList Xlm = new("XLM");

    public static readonly UnofficialCurrencyCodeList Xmr = new("XMR");

    public static readonly UnofficialCurrencyCodeList Xrp = new("XRP");

    public static readonly UnofficialCurrencyCodeList Zec = new("ZEC");

    public static readonly UnofficialCurrencyCodeList Zrx = new("ZRX");

    public static UnofficialCurrencyCodeList FromValue(string value) => FromValueCore(value);
}
